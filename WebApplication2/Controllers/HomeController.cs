using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Services;
using WebApplication2;

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

        // Now accept 'filter' and 'searchTerm'
        public async Task<IActionResult> Index(string filter, string searchTerm)
        {
            var outlets = await _context.Outlets.ToListAsync();
            var totalDown = outlets.FindAll(a => a.LastPingStatus == "Connection Lost").Count();
            ViewData["TotalDown"] = totalDown;
            
            var highPing = outlets.FindAll(a => a.LastPingStatus == "High Ping").Count();
            ViewData["HighPing"] = highPing;
            Console.WriteLine(ViewData["HighPing"]);
            var uplink = outlets.FindAll(a => a.LastPingStatus == "Good").Count();
            ViewData["Uplink"] = uplink;


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
                }
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                outlets = outlets.Where(x =>
                    (x.OutletName != null && x.OutletName.ToLower().Contains(searchTerm)) ||
                    (x.OutletCode != null && x.OutletCode.ToLower().Contains(searchTerm))
                ).ToList();
            }

            return View(outlets);
        }

        [HttpPost]
        public async Task<IActionResult> CheckConnections()
        {
            var outlets = await _context.Outlets.ToListAsync();

            foreach (var outlet in outlets)
            {
                var (status, avgTime) = await _pingService.CheckPingStatusAsync(outlet.IpAddress);
                outlet.LastPingStatus = status;
                outlet.LastPingTime = status == "Connection Lost" ? null : DateTime.Now;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
