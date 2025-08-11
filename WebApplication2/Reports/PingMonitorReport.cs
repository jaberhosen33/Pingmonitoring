using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using WebApplication2.Models;
using System.IO;

namespace WebApplication2.Reports
{
    public class PingMonitorReport : IDocument
    {
        private readonly List<Outlet> _outlets;
        private readonly int _up, _down, _highPing;
        private readonly string _logoPath; // Path to logo

        public PingMonitorReport(List<Outlet> outlets, int uplink, int totalDown, int highPing, string logoPath)
        {
            _outlets = outlets;
            _up = uplink;
            _down = totalDown;
            _highPing = highPing;
            _logoPath = logoPath;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(1, Unit.Centimetre);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Content().Column(col =>
                {
                    // 🔹 Add logo on top
                    // Load image from file
                    page.Header()
     .PaddingBottom(5)
     .Row(row =>
     {
         // Left side: Report Title and info
         row.RelativeItem().Column(col =>
         {
             col.Item().Text("Ping Monitor Report")
                 .Bold().FontSize(18).FontColor(Colors.Blue.Medium);

             col.Item().Text("ACI Logistics Limited")
                 .Bold().FontSize(10).FontColor(Colors.Green.Medium);
             col.Item().Text($"Generated on: {DateTime.Now:g}");

         });

         // Right side: Logo
         row.AutoItem()
             .Height(40)       // controls scaling
             .Image(_logoPath)
             .FitHeight();     // keeps aspect ratio
     })
     ;


                    col.Item().PaddingVertical(5).Row(row =>
                    {
                       
                        row.RelativeItem().AlignRight().Text($"Total Outlets: {_outlets.Count}");
                    });

                    col.Item().PaddingVertical(5).Row(row =>
                    {
                        row.AutoItem().PaddingLeft(10).Text($"❌ TOTAL DOWN: {_down}").FontColor(Colors.Red.Medium);
                    });

                    col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                    // Data table
                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(cols =>
                        {
                            cols.ConstantColumn(60);
                            cols.RelativeColumn(2);
                            cols.RelativeColumn();
                            cols.RelativeColumn();
                            cols.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("Code").Bold();
                            header.Cell().Element(CellStyle).Text("Name").Bold();
                            header.Cell().Element(CellStyle).Text("ISP").Bold();
                            header.Cell().Element(CellStyle).Text("Status").Bold();
                            header.Cell().Element(CellStyle).Text("Duration").Bold();
                        });

                        // Sort outlets by duration descending (longest ago first)
                        var sortedOutlets = _outlets
      .OrderByDescending(o => o.LastPingTime.HasValue ? DateTime.Now - o.LastPingTime.Value : TimeSpan.MaxValue)
      .ToList();


                        foreach (var outlet in sortedOutlets)
                        {
                            var statusColor = outlet.LastPingStatus == "Connection Lost" ? Colors.Red.Medium :
                                              outlet.LastPingStatus == "High Ping" ? Colors.Orange.Darken2 :
                                              Colors.Green.Darken2;

                            TimeSpan? duration = outlet.LastPingTime.HasValue
                                ? DateTime.Now - outlet.LastPingTime.Value
                                : (TimeSpan?)null;

                            table.Cell().Element(CellStyle).Text(outlet.OutletCode);
                            table.Cell().Element(CellStyle).Text(outlet.OutletName);
                            table.Cell().Element(CellStyle).Text(outlet.ISPName);
                            table.Cell().Element(CellStyle).Text(outlet.LastPingStatus).FontColor(statusColor);

                            var durationText = duration.HasValue
                                ? $"{duration.Value.Days}d {duration.Value.Hours}h {duration.Value.Minutes}m"
                                : "Never";

                            table.Cell().Element(CellStyle).Text(durationText);
                        }
                    });
                });
            });
        }

        private IContainer CellStyle(IContainer container) =>
            container.PaddingVertical(4).PaddingHorizontal(2).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
    }
}
