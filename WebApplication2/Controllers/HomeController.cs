using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using WebApplication2.Models;
using WebApplication2.Reports;
using WebApplication2.Services;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly PingService _pingService;

        public HomeController(AppDbContext context, PingService pingService)
        {
            _context = context;
            _pingService = pingService;
        }

        public async Task<IActionResult> Index(string filter, string searchTerm)
        {
            var outlets = await _context.Outlets.ToListAsync();
            ViewData["Alloutlets"] = outlets.Count();
            var totalDown = outlets.Count(a => a.LastPingStatus == "Connection Lost");
            ViewData["TotalDown"] = totalDown;

            var highPing = outlets.Count(a => a.LastPingStatus == "High Ping");
            ViewData["HighPing"] = highPing;

            var uplink = outlets.Count(a => a.LastPingStatus == "Good");
            ViewData["Uplink"] = uplink;
            //ispcount outlet
            //var TotalCCL = outlets.Count(a => a.ISPName == "CCL");
            //ViewData["CCL"] = TotalCCL;

             var TotalAmber = outlets.Count(a => a.ISPName == "Agni");
            ViewData["Agni"] = TotalAmber;


            if (!string.IsNullOrEmpty(filter))
            {
                switch (filter.ToLower())
                {
                    case "good":
                        outlets = outlets.Where(x => x.LastPingStatus == "Good").ToList();
                        break;
                    case "highping":
                        outlets = outlets.Where(x => x.LastPingStatus == "High Ping").ToList();
                        break;
                    case "lost":
                        outlets = outlets.Where(x => x.LastPingStatus == "Connection Lost").ToList();
                        break;
                    case "all":
                        outlets = outlets.Where(x => x.OutletCode.Count() == x.OutletCode.Count() ).ToList();
                        break;
                }
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                outlets = outlets.Where(x =>
                    (!string.IsNullOrEmpty(x.OutletName) && x.OutletName.ToLower().Contains(searchTerm)) ||
                    (!string.IsNullOrEmpty(x.OutletCode) && x.OutletCode.ToLower().Contains(searchTerm)) ||
                    (!string.IsNullOrEmpty(x.ISPName) && x.ISPName.ToLower().Contains(searchTerm))
                ).ToList();
            }

            return View(outlets);
        }

        [HttpPost]
        public async Task<IActionResult> CheckConnections()
        {
            var outlets = await _context.Outlets.ToListAsync();
            var semaphore = new SemaphoreSlim(50); // Adjust concurrency limit as needed
            var tasks = new List<Task>();

            foreach (var outlet in outlets)
            {
                await semaphore.WaitAsync();

                var task = Task.Run(async () =>
                {
                    try
                    {
                        var (status, avgTime) = await _pingService.CheckPingStatusAsync(outlet.IpAddress);
                        lock (outlet) // Optional: safe guard model state if used elsewhere
                        {
                            outlet.LastPingStatus = status;
                            //outlet.LastPingTime = status != "Connection Lost" ? null : DateTime.Now;

                            if ( status != "Connection Lost")
                            {
                                outlet.LastPingTime = DateTime.Now;
                            }
                        }
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });

                tasks.Add(task);
            }

            await Task.WhenAll(tasks);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [Route("Report/ExportPdf")]
        public IActionResult ExportPdf(string isp)
        {
            if (string.IsNullOrEmpty(isp))
                return BadRequest("Please select a valid ISP.");

          

            if (isp=="all")
            {
                var outlets = _context.Outlets
                    .Where(x => x.LastPingStatus == "Connection Lost")
                    .ToList();
                int uplink = outlets.Count(x => x.LastPingStatus == "Linked Up");
                int down = outlets.Count(x => x.LastPingStatus == "Connection Lost");
                int highPing = outlets.Count(x => x.LastPingStatus == "High Ping");
                var logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Image", "acilogistics.jpeg");
                var report = new PingMonitorReport(outlets, uplink, down, highPing, logoPath);
                var pdfBytes = report.GeneratePdf();

                return File(pdfBytes, "application/pdf", $"PingMonitor_{isp}_{DateTime.Now:yyyyMMddHHmm}.pdf");
            }
            else
            {
                var outlets = _context.Outlets
              .Where(x => x.LastPingStatus == "Connection Lost" && x.ISPName == isp)
              .ToList();
                int uplink = outlets.Count(x => x.LastPingStatus == "Linked Up");
                int down = outlets.Count(x => x.LastPingStatus == "Connection Lost");
                int highPing = outlets.Count(x => x.LastPingStatus == "High Ping");
                var logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Image", "acilogistics.jpeg");
                var report = new PingMonitorReport(outlets, uplink, down, highPing, logoPath);
                var pdfBytes = report.GeneratePdf();
                return File(pdfBytes, "application/pdf", $"PingMonitor_{isp}_{DateTime.Now:yyyyMMddHHmm}.pdf");
            }
          
        }
    }

            

            

    }

