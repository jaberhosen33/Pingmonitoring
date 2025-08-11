using Microsoft.EntityFrameworkCore;
using WebApplication2;
using WebApplication2.Services;
using QuestPDF.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

// Bind to specific IP and port
builder.WebHost.UseUrls("http://192.168.12.254:5000");

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<PingService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
QuestPDF.Settings.License = LicenseType.Community;

// Add services and middleware as usual
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
