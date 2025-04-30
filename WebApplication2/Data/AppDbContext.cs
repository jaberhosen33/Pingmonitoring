using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Outlet> Outlets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Outlet>()
                .Property(x => x.ISPPhone)
                .IsRequired(false); // Make ISPPhone optional!

            modelBuilder.Entity<Outlet>().HasData(
                new Outlet
                {
                    Id = 1,
                    OutletName = "Sadar Road Barisal",
                    OutletCode = "B004",
                    IpAddress = "172.18.4.5",
                    ISPName = "Drick",
                    ISPPhone = null,
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },
                new Outlet
                {
                    Id = 2,
                    OutletName = "Golpahar-CTG",
                    OutletCode = "C001",
                    IpAddress = "172.17.2.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 3,
                    OutletName = "Halishohor",
                    OutletCode = "C009",
                    IpAddress = "172.17.9.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 4,
                    OutletName = "Comilla",
                    OutletCode = "C011",
                    IpAddress = "172.17.11.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 5,
                    OutletName = "B.Baria",
                    OutletCode = "C012",
                    IpAddress = "172.15.4.1",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 6,
                    OutletName = "Comilla-2",
                    OutletCode = "C013",
                    IpAddress = "172.17.13.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 7,
                    OutletName = "Khulshi (New)",
                    OutletCode = "C015",
                    IpAddress = "172.17.15.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 8,
                    OutletName = "Chandina",
                    OutletCode = "C016",
                    IpAddress = "172.17.16.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 9,
                    OutletName = "Feni",
                    OutletCode = "C017",
                    IpAddress = "172.17.17.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 10,
                    OutletName = "Jamal Khan, CTG",
                    OutletCode = "C018",
                    IpAddress = "172.17.18.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 11,
                    OutletName = "Cox's Bazar",
                    OutletCode = "C019",
                    IpAddress = "172.17.19.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 12,
                    OutletName = "Brahmanbaria",
                    OutletCode = "C020",
                    IpAddress = "172.17.20.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 13,
                    OutletName = "Jhautola, Cox’s Bazar",
                    OutletCode = "C021",
                    IpAddress = "172.17.21.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 14,
                    OutletName = "Postogola",
                    OutletCode = "D002",
                    IpAddress = "10.1.83.1",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 15,
                    OutletName = "Uttara-6",
                    OutletCode = "D003",
                    IpAddress = "172.16.1.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 16,
                    OutletName = "Nakhalpara",
                    OutletCode = "D004",
                    IpAddress = "172.16.38.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 17,
                    OutletName = "Malibag",
                    OutletCode = "D006",
                    IpAddress = "172.16.53.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 18,
                    OutletName = "Green Road",
                    OutletCode = "D007",
                    IpAddress = "172.16.52.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 19,
                    OutletName = "Nazimuddin",
                    OutletCode = "D011",
                    IpAddress = "172.16.63.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 20,
                    OutletName = "Narayanganj",
                    OutletCode = "D014",
                    IpAddress = "172.16.202.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 21,
                    OutletName = "Uttara Chourasta",
                    OutletCode = "D016",
                    IpAddress = "172.16.2.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 22,
                    OutletName = "West Kafrul",
                    OutletCode = "D017",
                    IpAddress = "172.16.16.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 23,
                    OutletName = "Sutrapur",
                    OutletCode = "D018",
                    IpAddress = "172.16.23.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 24,
                    OutletName = "Sky View",
                    OutletCode = "D019",
                    IpAddress = "172.16.13.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 25,
                    OutletName = "Banani-1",
                    OutletCode = "D021",
                    IpAddress = "172.16.19.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 26,
                    OutletName = "Nikunjo",
                    OutletCode = "D023",
                    IpAddress = "172.16.10.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 27,
                    OutletName = "Tongi",
                    OutletCode = "D024",
                    IpAddress = "172.16.24.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 28,
                    OutletName = "Gulshan-2",
                    OutletCode = "D031",
                    IpAddress = "172.16.31.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 29,
                    OutletName = "Shajahan Road",
                    OutletCode = "D034",
                    IpAddress = "172.16.30.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 30,
                    OutletName = "Jatrabari-2",
                    OutletCode = "D041",
                    IpAddress = "172.16.36.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 31,
                    OutletName = "Azimpur",
                    OutletCode = "D045",
                    IpAddress = "172.16.3.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 32,
                    OutletName = "Lakecity",
                    OutletCode = "D046",
                    IpAddress = "172.16.46.1",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 33,
                    OutletName = "Joydevpur",
                    OutletCode = "D047",
                    IpAddress = "172.16.47.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 34,
                    OutletName = "North Banasree-2",
                    OutletCode = "D049",
                    IpAddress = "172.16.48.1",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 35,
                    OutletName = "Central Basabo-2",
                    OutletCode = "D051",
                    IpAddress = "172.16.51.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 36,
                    OutletName = "South Kajla",
                    OutletCode = "D053",
                    IpAddress = "172.16.54.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 37,
                    OutletName = "Rampura Mohanagar",
                    OutletCode = "D054",
                    IpAddress = "172.16.4.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 38,
                    OutletName = "Mirpur-12 Pollobi",
                    OutletCode = "D055",
                    IpAddress = "172.16.55.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 39,
                    OutletName = "Kazipara-2",
                    OutletCode = "D056",
                    IpAddress = "172.16.56.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 40,
                    OutletName = "Uttara 3",
                    OutletCode = "D058",
                    IpAddress = "172.16.58.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 41,
                    OutletName = "Monipuri Para",
                    OutletCode = "D059",
                    IpAddress = "172.16.59.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 42,
                    OutletName = "Gopibagh",
                    OutletCode = "D060",
                    IpAddress = "172.16.60.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 43,
                    OutletName = "Banani-2",
                    OutletCode = "D061",
                    IpAddress = "172.16.61.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 44,
                    OutletName = "Gulshan-1",
                    OutletCode = "D062",
                    IpAddress = "172.16.62.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 45,
                    OutletName = "Wari New",
                    OutletCode = "D063",
                    IpAddress = "172.16.64.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 46,
                    OutletName = "Panthapath",
                    OutletCode = "D064",
                    IpAddress = "172.16.21.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 47,
                    OutletName = "Mirpur-6",
                    OutletCode = "D065",
                    IpAddress = "172.16.15.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 48,
                    OutletName = "Dhaka Housing",
                    OutletCode = "D067",
                    IpAddress = "172.16.43.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 49,
                    OutletName = "Kaderabad Ho",
                    OutletCode = "D068",
                    IpAddress = "172.16.68.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 50,
                    OutletName = "Mirpur-1",
                    OutletCode = "D070",
                    IpAddress = "172.16.70.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 51,
                    OutletName = "Mirpur-10",
                    OutletCode = "D071",
                    IpAddress = "172.16.71.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 52,
                    OutletName = "Mirpur-11",
                    OutletCode = "D072",
                    IpAddress = "172.16.72.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 53,
                    OutletName = "Jigatola",
                    OutletCode = "D074",
                    IpAddress = "172.16.74.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 54,
                    OutletName = "Dhanmondi-27",
                    OutletCode = "D075",
                    IpAddress = "172.16.75.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 55,
                    OutletName = "Gulshan New",
                    OutletCode = "D076",
                    IpAddress = "172.16.76.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 56,
                    OutletName = "Keranigong",
                    OutletCode = "D078",
                    IpAddress = "172.15.2.1",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 57,
                    OutletName = "Askona",
                    OutletCode = "D079",
                    IpAddress = "172.16.79.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 58,
                    OutletName = "Mugda",
                    OutletCode = "D080",
                    IpAddress = "172.16.80.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 59,
                    OutletName = "Merul Badda",
                    OutletCode = "D081",
                    IpAddress = "172.16.81.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 60,
                    OutletName = "Golapbagh",
                    OutletCode = "D083",
                    IpAddress = "172.16.83.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 61,
                    OutletName = "Basundhara",
                    OutletCode = "D084",
                    IpAddress = "172.16.84.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 62,
                    OutletName = "Mohammadpur",
                    OutletCode = "D086",
                    IpAddress = "172.16.86.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 63,
                    OutletName = "Satarkul-Badda",
                    OutletCode = "D088",
                    IpAddress = "172.16.88.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 64,
                    OutletName = "Borobagh-Mirpur",
                    OutletCode = "D089",
                    IpAddress = "172.16.87.5",
                    ISPName = "CCL",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 65,
                    OutletName = "Mirpur-12",
                    OutletCode = "D091",
                    IpAddress = "172.16.91.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 66,
                    OutletName = "Uttara 3 Rabindra",
                    OutletCode = "D092",
                    IpAddress = "172.16.92.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 67,
                    OutletName = "Savar cantonment",
                    OutletCode = "D093",
                    IpAddress = "172.16.93.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 68,
                    OutletName = "Kamrangichor",
                    OutletCode = "D095",
                    IpAddress = "172.16.95.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 69,
                    OutletName = "Aftabnagar",
                    OutletCode = "D096",
                    IpAddress = "172.16.96.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 70,
                    OutletName = "Kashmiritola",
                    OutletCode = "D097",
                    IpAddress = "172.16.97.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 71,
                    OutletName = "Thana road, Savar",
                    OutletCode = "D098",
                    IpAddress = "172.16.98.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 72,
                    OutletName = "South keranigonj",
                    OutletCode = "D099",
                    IpAddress = "172.16.99.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 73,
                    OutletName = "Manikganj Bus Stand",
                    OutletCode = "D101",
                    IpAddress = "172.16.101.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 74,
                    OutletName = "Mirpur 10 Hoper goli",
                    OutletCode = "D102",
                    IpAddress = "172.16.102.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 75,
                    OutletName = "Ring Road, Md.pur",
                    OutletCode = "D104",
                    IpAddress = "172.16.104.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 76,
                    OutletName = "Moddho Badda",
                    OutletCode = "D106",
                    IpAddress = "nan",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 77,
                    OutletName = "Taltola, Agargaon",
                    OutletCode = "D108",
                    IpAddress = "172.16.108.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 78,
                    OutletName = "Bashundhara G-Block",
                    OutletCode = "D109",
                    IpAddress = "172.16.109.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 79,
                    OutletName = "Khulna Moylapota",
                    OutletCode = "K006",
                    IpAddress = "172.17.6.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 80,
                    OutletName = "Boyra, Khulna",
                    OutletCode = "K007",
                    IpAddress = "172.17.7.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 81,
                    OutletName = "South Central Rd Khulna",
                    OutletCode = "K008",
                    IpAddress = "172.18.108.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 82,
                    OutletName = "Bagura",
                    OutletCode = "R008",
                    IpAddress = "172.17.8.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 83,
                    OutletName = "Joypurhat",
                    OutletCode = "R009",
                    IpAddress = "172.18.9.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 84,
                    OutletName = "Naogaon",
                    OutletCode = "R010",
                    IpAddress = "172.18.10.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 85,
                    OutletName = "Alupatti, Rajshahi",
                    OutletCode = "R011",
                    IpAddress = "172.18.11.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 86,
                    OutletName = "Multiplan(Uposahar)",
                    OutletCode = "S001",
                    IpAddress = "172.17.27.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 87,
                    OutletName = "Sylmark(shibgang)",
                    OutletCode = "S002",
                    IpAddress = "172.17.26.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 88,
                    OutletName = "Sunrise(pathantola)",
                    OutletCode = "S003",
                    IpAddress = "172.17.25.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 89,
                    OutletName = "Zinda bazar",
                    OutletCode = "S006",
                    IpAddress = "172.17.28.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 90,
                    OutletName = "Beanibazar",
                    OutletCode = "S007",
                    IpAddress = "172.17.29.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 91,
                    OutletName = "Amberkhana",
                    OutletCode = "S008",
                    IpAddress = "172.17.30.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 92,
                    OutletName = "MoulviBazar",
                    OutletCode = "S009",
                    IpAddress = "172.17.31.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 93,
                    OutletName = "Barisal",
                    OutletCode = "F001",
                    IpAddress = "172.16.77.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 94,
                    OutletName = "Jamalpur",
                    OutletCode = "F002",
                    IpAddress = "172.16.5.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 95,
                    OutletName = "Feni",
                    OutletCode = "F003",
                    IpAddress = "172.15.3.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 96,
                    OutletName = "Mymensingh",
                    OutletCode = "F004",
                    IpAddress = "172.16.6.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 97,
                    OutletName = "Tongi Satash",
                    OutletCode = "F007",
                    IpAddress = "172.15.7.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 98,
                    OutletName = "Gulshan Link Road",
                    OutletCode = "F009",
                    IpAddress = "172.15.9.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 99,
                    OutletName = "Uttara 10( Rd-12)",
                    OutletCode = "F010",
                    IpAddress = "172.15.10.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 100,
                    OutletName = "Kathal Bagan",
                    OutletCode = "F012",
                    IpAddress = "172.15.12.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 101,
                    OutletName = "Banasree H block",
                    OutletCode = "F013",
                    IpAddress = "172.15.13.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 102,
                    OutletName = "Uttara 9 (3E)",
                    OutletCode = "F015",
                    IpAddress = "172.15.15.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 103,
                    OutletName = "Modhumita Rd,Tongi",
                    OutletCode = "F016",
                    IpAddress = "172.15.16.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 104,
                    OutletName = "Modhubagh",
                    OutletCode = "F017",
                    IpAddress = "172.15.17.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 105,
                    OutletName = "Mirpur 12 (B block)",
                    OutletCode = "F018",
                    IpAddress = "172.15.18.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 106,
                    OutletName = "Tajmahal road",
                    OutletCode = "F021",
                    IpAddress = "172.15.21.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 107,
                    OutletName = "Dholaikhal",
                    OutletCode = "F022",
                    IpAddress = "172.15.22.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 108,
                    OutletName = "Shymoli",
                    OutletCode = "F023",
                    IpAddress = "172.15.23.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 109,
                    OutletName = "Tangail",
                    OutletCode = "F024",
                    IpAddress = "172.15.1.1",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 110,
                    OutletName = "Prembagan",
                    OutletCode = "F027",
                    IpAddress = "172.15.27.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 111,
                    OutletName = "Uttara 9(road 10)",
                    OutletCode = "F030",
                    IpAddress = "172.15.30.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 112,
                    OutletName = "North Pirerbagh",
                    OutletCode = "F032",
                    IpAddress = "172.15.32.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 113,
                    OutletName = "Bhairab",
                    OutletCode = "F034",
                    IpAddress = "172.15.34.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 114,
                    OutletName = "Uttar tolarbagh",
                    OutletCode = "F038",
                    IpAddress = "172.15.38.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 115,
                    OutletName = "Hazipara",
                    OutletCode = "F039",
                    IpAddress = "172.15.39.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 116,
                    OutletName = "Mazar Road, Mirpur",
                    OutletCode = "F040",
                    IpAddress = "172.15.40.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 117,
                    OutletName = "Uttar badda",
                    OutletCode = "F041",
                    IpAddress = "172.15.41.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 118,
                    OutletName = "Jigatola post road",
                    OutletCode = "F044",
                    IpAddress = "172.15.44.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 119,
                    OutletName = "Khilgaon tilpapara",
                    OutletCode = "F046",
                    IpAddress = "172.15.46.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 120,
                    OutletName = "Kawla",
                    OutletCode = "F048",
                    IpAddress = "172.15.48.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 121,
                    OutletName = "Mirpur 10( C block)",
                    OutletCode = "F050",
                    IpAddress = "172.15.50.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 122,
                    OutletName = "Gandaria",
                    OutletCode = "F051",
                    IpAddress = "172.15.51.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 123,
                    OutletName = "Joydebpur Bus Stand",
                    OutletCode = "F053",
                    IpAddress = "172.15.53.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 124,
                    OutletName = "Buddho Mondir",
                    OutletCode = "F054",
                    IpAddress = "172.15.54.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 125,
                    OutletName = "Mirpur 12 Block Ta",
                    OutletCode = "F056",
                    IpAddress = "172.15.56.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 126,
                    OutletName = "Tannery mor, Hazaribagh",
                    OutletCode = "F062",
                    IpAddress = "172.15.62.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 127,
                    OutletName = "Shailbari, Rupnagar",
                    OutletCode = "F064",
                    IpAddress = "172.15.64.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 128,
                    OutletName = "Thana Road , Uttar badda",
                    OutletCode = "F065",
                    IpAddress = "172.15.65.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 129,
                    OutletName = "Madrasa road",
                    OutletCode = "F066",
                    IpAddress = "172.15.66.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 130,
                    OutletName = "Shonir akhra",
                    OutletCode = "F067",
                    IpAddress = "172.15.67.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 131,
                    OutletName = "Masdair, Narayanganj",
                    OutletCode = "F070",
                    IpAddress = "172.15.70.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 132,
                    OutletName = "Kumarpara, Sylhet",
                    OutletCode = "F071",
                    IpAddress = "172.15.71.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 133,
                    OutletName = "E.shewrapara Orbit Goli",
                    OutletCode = "F073",
                    IpAddress = "172.15.73.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 134,
                    OutletName = "Tongi collage road",
                    OutletCode = "F074",
                    IpAddress = "172.15.74.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 135,
                    OutletName = "W. Shewrapara Olirtek",
                    OutletCode = "F075",
                    IpAddress = "172.15.75.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 136,
                    OutletName = "mawna",
                    OutletCode = "F077",
                    IpAddress = "172.15.77.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 137,
                    OutletName = "Shimultali",
                    OutletCode = "F079",
                    IpAddress = "172.15.79.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 138,
                    OutletName = "Board Bazar",
                    OutletCode = "F081",
                    IpAddress = "172.15.81.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 139,
                    OutletName = "Dakshinkhan",
                    OutletCode = "F082",
                    IpAddress = "172.15.82.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 140,
                    OutletName = "Sylhet Golapganj",
                    OutletCode = "F083",
                    IpAddress = "172.15.83.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 141,
                    OutletName = "Uttar kazipara",
                    OutletCode = "F085",
                    IpAddress = "172.15.85.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 142,
                    OutletName = "Narinda",
                    OutletCode = "F086",
                    IpAddress = "172.15.86.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 143,
                    OutletName = "Savar new market",
                    OutletCode = "F087",
                    IpAddress = "172.15.87.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 144,
                    OutletName = "Hazigonj, Chandpur",
                    OutletCode = "F088",
                    IpAddress = "172.15.88.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 145,
                    OutletName = "Mohammadia Housing",
                    OutletCode = "F089",
                    IpAddress = "172.15.89.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 146,
                    OutletName = "Shafipur Hiramoti tower",
                    OutletCode = "F090",
                    IpAddress = "172.15.90.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 147,
                    OutletName = "Sirajgonj Sarwardi",
                    OutletCode = "F091",
                    IpAddress = "172.15.91.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 148,
                    OutletName = "Noakhali Maijdi court",
                    OutletCode = "F092",
                    IpAddress = "172.15.92.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 149,
                    OutletName = "Faridpur Jhiltuli",
                    OutletCode = "F093",
                    IpAddress = "172.15.93.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 150,
                    OutletName = "Mymansingh masterbari",
                    OutletCode = "F094",
                    IpAddress = "172.15.94.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 151,
                    OutletName = "Kustia Shapla Chattar",
                    OutletCode = "F095",
                    IpAddress = "172.15.95.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 152,
                    OutletName = "Tangail main road",
                    OutletCode = "F096",
                    IpAddress = "172.15.96.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 153,
                    OutletName = "Rangpur shymoli",
                    OutletCode = "F097",
                    IpAddress = "172.15.97.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 154,
                    OutletName = "Lalbagh",
                    OutletCode = "F098",
                    IpAddress = "172.15.98.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 155,
                    OutletName = "Manikganj Royal tower",
                    OutletCode = "F099",
                    IpAddress = "172.15.99.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 156,
                    OutletName = "CTG Agrabad",
                    OutletCode = "F100",
                    IpAddress = "172.15.100.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 157,
                    OutletName = "Gazipur Bonmala",
                    OutletCode = "F101",
                    IpAddress = "172.15.101.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 158,
                    OutletName = "Ashuganj Bazar",
                    OutletCode = "F102",
                    IpAddress = "172.15.102.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 159,
                    OutletName = "Gazipur konabari",
                    OutletCode = "F103",
                    IpAddress = "172.15.103.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 160,
                    OutletName = "Bhairab Bus stand",
                    OutletCode = "F104",
                    IpAddress = "172.15.104.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 161,
                    OutletName = "Narshingdi Judge court",
                    OutletCode = "F105",
                    IpAddress = "172.15.105.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 162,
                    OutletName = "CTG chadgaon housing",
                    OutletCode = "F107",
                    IpAddress = "172.15.107.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 163,
                    OutletName = "Hazaribagh",
                    OutletCode = "F109",
                    IpAddress = "172.15.109.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 164,
                    OutletName = "Gopalganj College road",
                    OutletCode = "F110",
                    IpAddress = "172.15.110.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 165,
                    OutletName = "New eskaton",
                    OutletCode = "F111",
                    IpAddress = "172.15.111.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 166,
                    OutletName = "South banasree-2",
                    OutletCode = "F112",
                    IpAddress = "172.15.112.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 167,
                    OutletName = "Barishal bogura road",
                    OutletCode = "F113",
                    IpAddress = "172.15.113.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 168,
                    OutletName = "Srimangal",
                    OutletCode = "F114",
                    IpAddress = "172.15.114.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 169,
                    OutletName = "Habiganj Kalibari",
                    OutletCode = "F115",
                    IpAddress = "172.15.115.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 170,
                    OutletName = "Mymenshingh Railroad",
                    OutletCode = "F116",
                    IpAddress = "172.15.116.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 171,
                    OutletName = "Mirpur-2",
                    OutletCode = "F118",
                    IpAddress = "172.15.118.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 172,
                    OutletName = "Memberbari",
                    OutletCode = "F119",
                    IpAddress = "172.15.119.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 173,
                    OutletName = "Baipal RMST tower",
                    OutletCode = "F120",
                    IpAddress = "172.15.120.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 174,
                    OutletName = "Aftabnagar",
                    OutletCode = "F121",
                    IpAddress = "172.15.121.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 175,
                    OutletName = "Natun bazar",
                    OutletCode = "F122",
                    IpAddress = "172.15.122.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 176,
                    OutletName = "Jashore Rasel chottor",
                    OutletCode = "F123",
                    IpAddress = "172.15.123.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 177,
                    OutletName = "Shewrapara wasa Rd",
                    OutletCode = "F124",
                    IpAddress = "172.15.124.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 178,
                    OutletName = "Thakurgaon kalibari",
                    OutletCode = "F125",
                    IpAddress = "172.15.125.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 179,
                    OutletName = "Bajitpur kishoregonj",
                    OutletCode = "F127",
                    IpAddress = "172.15.127.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 180,
                    OutletName = "Nababganj Bagmara",
                    OutletCode = "F128",
                    IpAddress = "172.15.128.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 181,
                    OutletName = "Daulatpur",
                    OutletCode = "F129",
                    IpAddress = "172.15.129.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 182,
                    OutletName = "West kazipara",
                    OutletCode = "F130",
                    IpAddress = "172.15.130.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 183,
                    OutletName = "Dinajpur Ganstola",
                    OutletCode = "F131",
                    IpAddress = "172.15.131.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 184,
                    OutletName = "konapara Demra",
                    OutletCode = "F132",
                    IpAddress = "172.15.132.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 185,
                    OutletName = "Natore",
                    OutletCode = "F133",
                    IpAddress = "172.15.133.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 186,
                    OutletName = "Dhaka uddan",
                    OutletCode = "F134",
                    IpAddress = "172.15.134.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 187,
                    OutletName = "Charpara mymansingh",
                    OutletCode = "F135",
                    IpAddress = "172.15.135.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 188,
                    OutletName = "South sastapur",
                    OutletCode = "F136",
                    IpAddress = "172.15.136.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 189,
                    OutletName = "Chunkutia",
                    OutletCode = "F138",
                    IpAddress = "172.15.138.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 190,
                    OutletName = "Siddhirganj",
                    OutletCode = "F139",
                    IpAddress = "172.15.139.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 191,
                    OutletName = "Narail",
                    OutletCode = "F140",
                    IpAddress = "172.15.140.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 192,
                    OutletName = "Joypara Dohar",
                    OutletCode = "F141",
                    IpAddress = "172.15.141.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 193,
                    OutletName = "Uttar khapara Tongi",
                    OutletCode = "F142",
                    IpAddress = "172.15.142.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 194,
                    OutletName = "Chatak",
                    OutletCode = "F143",
                    IpAddress = "172.15.143.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 195,
                    OutletName = "Mirpur 14",
                    OutletCode = "F144",
                    IpAddress = "172.15.144.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 196,
                    OutletName = "kashimpur",
                    OutletCode = "F145",
                    IpAddress = "172.15.145.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 197,
                    OutletName = "jamgora",
                    OutletCode = "F146",
                    IpAddress = "172.15.146.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 198,
                    OutletName = "Ranabhola",
                    OutletCode = "F147",
                    IpAddress = "172.15.147.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 199,
                    OutletName = "Ishwardi",
                    OutletCode = "F148",
                    IpAddress = "172.15.148.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 200,
                    OutletName = "Savar polli bidyut",
                    OutletCode = "F149",
                    IpAddress = "172.15.149.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 201,
                    OutletName = "Munshiganj",
                    OutletCode = "F150",
                    IpAddress = "172.15.150.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 202,
                    OutletName = "Muktarbari road",
                    OutletCode = "F151",
                    IpAddress = "172.15.151.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 203,
                    OutletName = "Kapasia",
                    OutletCode = "F152",
                    IpAddress = "172.15.152.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 204,
                    OutletName = "Faridganj",
                    OutletCode = "F153",
                    IpAddress = "172.15.153.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 205,
                    OutletName = "Chandpur",
                    OutletCode = "F154",
                    IpAddress = "172.15.154.5",
                    ISPName = "nan",
                    ISPPhone = null,
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 206,
                    OutletName = "Tangail mirzapur",
                    OutletCode = "F155",
                    IpAddress = "172.15.155.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 207,
                    OutletName = "Narshingdi madhobdi",
                    OutletCode = "F156",
                    IpAddress = "172.15.156.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 208,
                    OutletName = "Kishorgonj Katiadi",
                    OutletCode = "F157",
                    IpAddress = "172.15.157.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 209,
                    OutletName = "Khulna sonadanga",
                    OutletCode = "F158",
                    IpAddress = "172.15.158.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 210,
                    OutletName = "Sylhet Goalabazar",
                    OutletCode = "F159",
                    IpAddress = "172.15.159.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 211,
                    OutletName = "Mirpur Ahamednagar",
                    OutletCode = "F160",
                    IpAddress = "172.15.160.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 212,
                    OutletName = "Bhaluka",
                    OutletCode = "F161",
                    IpAddress = "172.15.161.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 213,
                    OutletName = "Uttarkhan Mazar",
                    OutletCode = "F162",
                    IpAddress = "172.15.162.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 214,
                    OutletName = "Mymansingh Trishal",
                    OutletCode = "F163",
                    IpAddress = "172.15.163.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 215,
                    OutletName = "Matikata",
                    OutletCode = "F164",
                    IpAddress = "172.15.164.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 216,
                    OutletName = "Laksham",
                    OutletCode = "F165",
                    IpAddress = "172.15.165.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 217,
                    OutletName = "Sylhet bishwanath",
                    OutletCode = "F166",
                    IpAddress = "172.15.166.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 218,
                    OutletName = "Narayanganj Bandar",
                    OutletCode = "F167",
                    IpAddress = "172.15.167.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 219,
                    OutletName = "Sherpur",
                    OutletCode = "F168",
                    IpAddress = "172.15.168.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 220,
                    OutletName = "Sirajdikhan",
                    OutletCode = "F170",
                    IpAddress = "172.15.170.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 221,
                    OutletName = "Banasree E block",
                    OutletCode = "F172",
                    IpAddress = "172.15.172.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 222,
                    OutletName = "Ashulia",
                    OutletCode = "F173",
                    IpAddress = "172.15.173.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 223,
                    OutletName = "Kustia bheramara",
                    OutletCode = "F174",
                    IpAddress = "172.15.174.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 224,
                    OutletName = "Gazipur chourasta",
                    OutletCode = "F175",
                    IpAddress = "172.15.175.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 225,
                    OutletName = "Kishoregonj Station Rd",
                    OutletCode = "F177",
                    IpAddress = "172.15.177.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 226,
                    OutletName = "Mission road chadpur",
                    OutletCode = "F178",
                    IpAddress = "172.15.178.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 227,
                    OutletName = "Tangail sabalia",
                    OutletCode = "F179",
                    IpAddress = "172.15.179.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 228,
                    OutletName = "Bosila Mohammadpur",
                    OutletCode = "F180",
                    IpAddress = "172.15.180.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 229,
                    OutletName = "Feni chagalnaiya",
                    OutletCode = "F181",
                    IpAddress = "172.15.181.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 230,
                    OutletName = "Hemayetpur",
                    OutletCode = "F182",
                    IpAddress = "172.15.182.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 231,
                    OutletName = "Gazipur Monipur",
                    OutletCode = "F184",
                    IpAddress = "172.15.184.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 232,
                    OutletName = "Satkhira",
                    OutletCode = "F185",
                    IpAddress = "172.15.185.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 233,
                    OutletName = "Narayangonj vulta",
                    OutletCode = "F187",
                    IpAddress = "172.15.187.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 234,
                    OutletName = "Patuakhali subidhkhali",
                    OutletCode = "F188",
                    IpAddress = "172.15.188.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 235,
                    OutletName = "Sunamganj Jagannathpur",
                    OutletCode = "F189",
                    IpAddress = "172.15.189.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 236,
                    OutletName = "Courtbari",
                    OutletCode = "F190",
                    IpAddress = "172.15.190.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 237,
                    OutletName = "Jhalakathi",
                    OutletCode = "F191",
                    IpAddress = "172.15.191.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 238,
                    OutletName = "Pirojpur bhandaria",
                    OutletCode = "F192",
                    IpAddress = "172.15.192.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 239,
                    OutletName = "CTG raozan",
                    OutletCode = "F193",
                    IpAddress = "172.15.193.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 240,
                    OutletName = "Zinzira",
                    OutletCode = "F194",
                    IpAddress = "172.15.194.5",
                    ISPName = "nan",
                    ISPPhone = null,
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 241,
                    OutletName = "Gazipur Barabari",
                    OutletCode = "F195",
                    IpAddress = "172.15.195.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 242,
                    OutletName = "Kurigram",
                    OutletCode = "F196",
                    IpAddress = "172.15.196.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 243,
                    OutletName = "Lakhsmipur",
                    OutletCode = "F197",
                    IpAddress = "172.15.197.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 244,
                    OutletName = "Chauddagram",
                    OutletCode = "F198",
                    IpAddress = "172.15.198.5",
                    ISPName = "nan",
                    ISPPhone = null,
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 245,
                    OutletName = "NG Hirajheel",
                    OutletCode = "F199",
                    IpAddress = "172.15.199.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 246,
                    OutletName = "Gazipur Bangla bazar",
                    OutletCode = "F200",
                    IpAddress = "172.15.200.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 247,
                    OutletName = "Barguna",
                    OutletCode = "F201",
                    IpAddress = "172.15.201.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 248,
                    OutletName = "Sanarpara Siddirganj",
                    OutletCode = "F202",
                    IpAddress = "172.15.202.5",
                    ISPName = "nan",
                    ISPPhone = null,
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 249,
                    OutletName = "Chapainawabhgonj",
                    OutletCode = "F203",
                    IpAddress = "172.15.203.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 250,
                    OutletName = "Panchagar",
                    OutletCode = "F204",
                    IpAddress = "172.15.204.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 251,
                    OutletName = "Bogura sherpur",
                    OutletCode = "F205",
                    IpAddress = "172.15.205.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 252,
                    OutletName = "Tangail karatia",
                    OutletCode = "F206",
                    IpAddress = "172.15.206.5",
                    ISPName = "nan",
                    ISPPhone = null,
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 253,
                    OutletName = "Jessore arabpur",
                    OutletCode = "F208",
                    IpAddress = "172.15.208.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 254,
                    OutletName = "Shariatpur",
                    OutletCode = "F209",
                    IpAddress = "172.15.209.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 255,
                    OutletName = "Rajshahi Dorikorbona",
                    OutletCode = "F210",
                    IpAddress = "172.15.210.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 256,
                    OutletName = "Patuakhali",
                    OutletCode = "F211",
                    IpAddress = "172.15.211.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 257,
                    OutletName = "Kurigram Nageswari",
                    OutletCode = "F212",
                    IpAddress = "172.15.212.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073045.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 258,
                    OutletName = "Keranigonj Oil Ghat",
                    OutletCode = "F213",
                    IpAddress = "172.15.213.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 259,
                    OutletName = "Alaul Avenue ,Uttara 6",
                    OutletCode = "F214",
                    IpAddress = "172.15.214.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 260,
                    OutletName = "Rahimanagar Kachua",
                    OutletCode = "F215",
                    IpAddress = "172.15.215.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 261,
                    OutletName = "Birampur Dinajpur",
                    OutletCode = "F216",
                    IpAddress = "172.15.216.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 262,
                    OutletName = "Seed Store Mymensing",
                    OutletCode = "F217",
                    IpAddress = "172.15.217.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 263,
                    OutletName = "Rupatoli Barishal",
                    OutletCode = "F218",
                    IpAddress = "172.15.218.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 264,
                    OutletName = "Magura Sadar",
                    OutletCode = "F219",
                    IpAddress = "172.15.219.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 265,
                    OutletName = "Kashiani Gopalganj",
                    OutletCode = "F220",
                    IpAddress = "172.15.220.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 266,
                    OutletName = "Kalibari Shaharasti Chandpur",
                    OutletCode = "F221",
                    IpAddress = "172.15.221.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 267,
                    OutletName = "Sharifpur Gazipur(Maleker Bari)",
                    OutletCode = "F222",
                    IpAddress = "172.15.222.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 268,
                    OutletName = "Pirojpur",
                    OutletCode = "F223",
                    IpAddress = "172.15.223.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 269,
                    OutletName = "Road 12, Nikunja 2",
                    OutletCode = "F224",
                    IpAddress = "172.15.224.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 270,
                    OutletName = "Rayerbagh",
                    OutletCode = "F226",
                    IpAddress = "172.15.226.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 271,
                    OutletName = "Muktagasa Mymensingh",
                    OutletCode = "F227",
                    IpAddress = "172.15.227.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 272,
                    OutletName = "Dhonia",
                    OutletCode = "F228",
                    IpAddress = "172.15.228.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 273,
                    OutletName = "Saruliya, Demra",
                    OutletCode = "F229",
                    IpAddress = "172.15.229.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 274,
                    OutletName = "Shibchar Madaripur",
                    OutletCode = "F231",
                    IpAddress = "172.15.231.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 275,
                    OutletName = "Nandail Mymensingh",
                    OutletCode = "F232",
                    IpAddress = "172.15.232.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 276,
                    OutletName = "Kachua Chandpur",
                    OutletCode = "F234",
                    IpAddress = "172.15.234.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 277,
                    OutletName = "Radio Colony Savar",
                    OutletCode = "F235",
                    IpAddress = "172.15.235.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 278,
                    OutletName = "Madhupur Tangail",
                    OutletCode = "F237",
                    IpAddress = "172.15.237.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 279,
                    OutletName = "Sakhipur Tangail",
                    OutletCode = "F238",
                    IpAddress = "172.15.238.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 280,
                    OutletName = "Bogura Uposhahar",
                    OutletCode = "F239",
                    IpAddress = "172.15.239.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 281,
                    OutletName = "Mugda Hospital Road",
                    OutletCode = "F240",
                    IpAddress = "172.15.240.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 282,
                    OutletName = "Bakshiganj Jamalpur",
                    OutletCode = "F241",
                    IpAddress = "172.15.25.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 283,
                    OutletName = "Rayerbazar",
                    OutletCode = "F242",
                    IpAddress = "172.15.242.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 284,
                    OutletName = "Picture Place Khulna",
                    OutletCode = "F244",
                    IpAddress = "172.15.244.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 285,
                    OutletName = "Moulovibazar Sherpur",
                    OutletCode = "F245",
                    IpAddress = "172.15.245.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 286,
                    OutletName = "Mirer Bazar Gazipur",
                    OutletCode = "F246",
                    IpAddress = "172.15.246.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 287,
                    OutletName = "Kolapara Patuakhali",
                    OutletCode = "F247",
                    IpAddress = "172.15.247.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 288,
                    OutletName = "Baro Dewraa Tongi",
                    OutletCode = "F249",
                    IpAddress = "172.15.249.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 289,
                    OutletName = "Kamarpara",
                    OutletCode = "F250",
                    IpAddress = "172.15.250.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 290,
                    OutletName = "Diabetics Mor Dinajpur",
                    OutletCode = "F252",
                    IpAddress = "172.15.252.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 291,
                    OutletName = "CTG Sitakunda",
                    OutletCode = "F253",
                    IpAddress = "172.15.253.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 292,
                    OutletName = "Dattabari Bogura",
                    OutletCode = "F254",
                    IpAddress = "172.15.254.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 293,
                    OutletName = "Shahparan Sylhet",
                    OutletCode = "F255",
                    IpAddress = "172.15.255.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 294,
                    OutletName = "Badda Joy Bangla Mor",
                    OutletCode = "F256",
                    IpAddress = "172.17.56.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 295,
                    OutletName = "Boda Panchagar",
                    OutletCode = "F257",
                    IpAddress = "172.17.57.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 296,
                    OutletName = "Kholamora Keraniganj",
                    OutletCode = "F258",
                    IpAddress = "172.17.58.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 297,
                    OutletName = "Barishal C & B Road",
                    OutletCode = "F260",
                    IpAddress = "172.17.60.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 298,
                    OutletName = "Lalmai Cumilla",
                    OutletCode = "F263",
                    IpAddress = "172.17.63.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 299,
                    OutletName = "Ghatail Tangail",
                    OutletCode = "F268",
                    IpAddress = "172.17.68.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 300,
                    OutletName = "Bandarban",
                    OutletCode = "F269",
                    IpAddress = "172.17.69.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 301,
                    OutletName = "Khalpar Narsingdi",
                    OutletCode = "F270",
                    IpAddress = "172.17.70.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 302,
                    OutletName = "Thakurgaon Pirganj",
                    OutletCode = "F271",
                    IpAddress = "172.17.71.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 303,
                    OutletName = "Chakaria Coxs'Bazar",
                    OutletCode = "F272",
                    IpAddress = "172.17.72.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 304,
                    OutletName = "Borhanuddin Bhola",
                    OutletCode = "F274",
                    IpAddress = "172.17.74.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 305,
                    OutletName = "R.K . Mission Road",
                    OutletCode = "F275",
                    IpAddress = "172.17.75.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 306,
                    OutletName = "Babar Road",
                    OutletCode = "F276",
                    IpAddress = "172.17.76.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 307,
                    OutletName = "Ramganj Lakshmipur",
                    OutletCode = "F277",
                    IpAddress = "172.17.77.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 308,
                    OutletName = "Daganbhuiyan",
                    OutletCode = "F278",
                    IpAddress = "172.17.78.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 309,
                    OutletName = "Chuddagram Cumilla",
                    OutletCode = "F279",
                    IpAddress = "172.17.79.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 310,
                    OutletName = "Merajnagar",
                    OutletCode = "F280",
                    IpAddress = "172.17.80.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 311,
                    OutletName = "Salna Gazipur",
                    OutletCode = "F283",
                    IpAddress = "172.17.83.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 312,
                    OutletName = "Court Bazar Rajshahi",
                    OutletCode = "F284",
                    IpAddress = "172.17.84.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 313,
                    OutletName = "Amtali Barguna",
                    OutletCode = "F285",
                    IpAddress = "172.17.85.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 314,
                    OutletName = "Rajbari",
                    OutletCode = "F286",
                    IpAddress = "172.17.86.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 315,
                    OutletName = "Lalmonirhat",
                    OutletCode = "F287",
                    IpAddress = "172.17.87.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 316,
                    OutletName = "Bosila Uttarpara",
                    OutletCode = "F288",
                    IpAddress = "172.17.88.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 317,
                    OutletName = "Teknaf",
                    OutletCode = "F289",
                    IpAddress = "172.17.89.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 318,
                    OutletName = "Pakundia",
                    OutletCode = "F290",
                    IpAddress = "172.17.90.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 319,
                    OutletName = "Ishwardi Bazar",
                    OutletCode = "F291",
                    IpAddress = "172.17.91.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 320,
                    OutletName = "Mijmiji NG",
                    OutletCode = "F292",
                    IpAddress = "172.17.92.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 321,
                    OutletName = "Kadamtali",
                    OutletCode = "F293",
                    IpAddress = "172.17.93.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 322,
                    OutletName = "Kalkini Madaripur",
                    OutletCode = "F294",
                    IpAddress = "172.17.94.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 323,
                    OutletName = "Bonpara Natore",
                    OutletCode = "F295",
                    IpAddress = "nan",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 324,
                    OutletName = "Janata Mor Faridpur",
                    OutletCode = "F296",
                    IpAddress = "172.17.96.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 325,
                    OutletName = "Gorgoria Masterbari",
                    OutletCode = "F297",
                    IpAddress = "172.17.97.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 326,
                    OutletName = "Rohitpur",
                    OutletCode = "F298",
                    IpAddress = "172.17.98.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 327,
                    OutletName = "West Merul Badda",
                    OutletCode = "F299",
                    IpAddress = "172.17.99.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 328,
                    OutletName = "Zila Sarani Mor Kishoreganj",
                    OutletCode = "F300",
                    IpAddress = "172.17.100.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 329,
                    OutletName = "Bou Bazar Kishorganj",
                    OutletCode = "F301",
                    IpAddress = "172.17.101.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 330,
                    OutletName = "Panichattor Madaripur",
                    OutletCode = "F302",
                    IpAddress = "172.17.102.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 331,
                    OutletName = "Kurpur Netrokona",
                    OutletCode = "F305",
                    IpAddress = "172.17.102.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 332,
                    OutletName = "Gobindoganj Gaibandha",
                    OutletCode = "F306",
                    IpAddress = "172.17.106.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 333,
                    OutletName = "Gouronadi Barishal",
                    OutletCode = "F307",
                    IpAddress = "172.17.107.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 334,
                    OutletName = "Abu naser Mor Khulna",
                    OutletCode = "F308",
                    IpAddress = "172.17.108.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 335,
                    OutletName = "Hamid Road pabna",
                    OutletCode = "F309",
                    IpAddress = "172.17.109.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 336,
                    OutletName = "Biconmor Rongpur",
                    OutletCode = "F310",
                    IpAddress = "172.17.110.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 337,
                    OutletName = "Shafimiar Bajar Jamalpur",
                    OutletCode = "F311",
                    IpAddress = "172.17.111.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 338,
                    OutletName = "Beltola Jail Road jassore",
                    OutletCode = "F312",
                    IpAddress = "172.17.112.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 339,
                    OutletName = "Nimai kasari bazar",
                    OutletCode = "F313",
                    IpAddress = "172.17.113.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 340,
                    OutletName = "Noyapara Habiganj",
                    OutletCode = "F314",
                    IpAddress = "172.17.114.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 341,
                    OutletName = "Shayestaganj Habiganj",
                    OutletCode = "F315",
                    IpAddress = "172.17.115.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 342,
                    OutletName = "Ramu Coxs bazar",
                    OutletCode = "F316",
                    IpAddress = "172.17.116.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 343,
                    OutletName = "Mathbaria",
                    OutletCode = "F317",
                    IpAddress = "172.17.117.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 344,
                    OutletName = "Atibazar Keraniganj",
                    OutletCode = "F318",
                    IpAddress = "172.17.118.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 345,
                    OutletName = "Gandaa Savar Outlet",
                    OutletCode = "F319",
                    IpAddress = "172.17.119.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 346,
                    OutletName = "Keshorhat Rajshahi",
                    OutletCode = "F320",
                    IpAddress = "172.17.120.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 347,
                    OutletName = "Chandrapur Bazar Shariatpur",
                    OutletCode = "F321",
                    IpAddress = "172.17.121.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 348,
                    OutletName = "Lohogora Narail",
                    OutletCode = "F322",
                    IpAddress = "172.17.122.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 349,
                    OutletName = "Fulbaria  Dinajpur",
                    OutletCode = "F323",
                    IpAddress = "172.17.123.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 350,
                    OutletName = "Bhola Sadar",
                    OutletCode = "F324",
                    IpAddress = "172.17.124.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 351,
                    OutletName = "Eastern Housing",
                    OutletCode = "F325",
                    IpAddress = "172.17.125.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 352,
                    OutletName = "Nabiganj Hobiganj",
                    OutletCode = "F326",
                    IpAddress = "172.17.126.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 353,
                    OutletName = "Wabda Road Rampura",
                    OutletCode = "F327",
                    IpAddress = "172.17.127.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 354,
                    OutletName = "Sreenagar Munshiganj",
                    OutletCode = "F328",
                    IpAddress = "172.17.128.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 355,
                    OutletName = "Bhurungamari Kurigram",
                    OutletCode = "F329",
                    IpAddress = "172.17.129.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 356,
                    OutletName = "Radhanagar Pabna",
                    OutletCode = "F330",
                    IpAddress = "172.17.130.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 357,
                    OutletName = "Saidpur Nilphamari",
                    OutletCode = "F331",
                    IpAddress = "172.17.131.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 358,
                    OutletName = "Shapahar Naogaon",
                    OutletCode = "F332",
                    IpAddress = "172.17.132.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 359,
                    OutletName = "Naohata Rajshahi",
                    OutletCode = "F333",
                    IpAddress = "172.17.133.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 360,
                    OutletName = "birgonj Dinajpur",
                    OutletCode = "F334",
                    IpAddress = "172.17.134.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 361,
                    OutletName = "M A Jalil Sarak ,Barishal",
                    OutletCode = "F335",
                    IpAddress = "172.17.135.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 362,
                    OutletName = "DC Bridge  Madaripur",
                    OutletCode = "F336",
                    IpAddress = "172.17.136.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 363,
                    OutletName = "Gollamari Khulna",
                    OutletCode = "F337",
                    IpAddress = "172.17.137.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 364,
                    OutletName = "D B Road Gaibanda",
                    OutletCode = "F338",
                    IpAddress = "172.17.138.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 365,
                    OutletName = "Shetabganj Dinajpur",
                    OutletCode = "F339",
                    IpAddress = "172.17.139.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 366,
                    OutletName = "Bangla Bazar Barishal",
                    OutletCode = "F340",
                    IpAddress = "172.17.140.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 367,
                    OutletName = "Baunia",
                    OutletCode = "F341",
                    IpAddress = "172.17.15.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 368,
                    OutletName = "Cant Mor Mymenisingh",
                    OutletCode = "F342",
                    IpAddress = "172.17.142.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 369,
                    OutletName = "Karimganj Keshorganj",
                    OutletCode = "F344",
                    IpAddress = "172.17.144.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 370,
                    OutletName = "Atharobari Mymensingh",
                    OutletCode = "F345",
                    IpAddress = "172.17.145.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 371,
                    OutletName = "Palbari Jessore",
                    OutletCode = "F346",
                    IpAddress = "172.17.146.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 372,
                    OutletName = "Shibpur Narshingdi",
                    OutletCode = "F347",
                    IpAddress = "172.17.147.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 373,
                    OutletName = "Court Bazar Ukhia",
                    OutletCode = "F348",
                    IpAddress = "172.17.148.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 374,
                    OutletName = "Monirampur Jessore",
                    OutletCode = "F349",
                    IpAddress = "172.17.149.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 375,
                    OutletName = "Bhabaniganj Bagmara Raj",
                    OutletCode = "F350",
                    IpAddress = "172.17.150.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 376,
                    OutletName = "Jafrabad",
                    OutletCode = "F351",
                    IpAddress = "172.17.151.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 377,
                    OutletName = "Paterbag South Dhonia",
                    OutletCode = "F352",
                    IpAddress = "172.17.152.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 378,
                    OutletName = "Bhedergoanj Shariatpur",
                    OutletCode = "F354",
                    IpAddress = "172.17.154.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 379,
                    OutletName = "Natullabad",
                    OutletCode = "F355",
                    IpAddress = "172.17.155.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 380,
                    OutletName = "Chowgacha Jessore",
                    OutletCode = "F356",
                    IpAddress = "172.17.156.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 381,
                    OutletName = "Bagha Rajshahi",
                    OutletCode = "F357",
                    IpAddress = "172.17.157.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 382,
                    OutletName = "Gobindapur Bazar S.Akhra",
                    OutletCode = "F358",
                    IpAddress = "172.17.158.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 383,
                    OutletName = "Pairachattar Jhenadah",
                    OutletCode = "F359",
                    IpAddress = "172.17.159.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 384,
                    OutletName = "Kuliarchar Kishoreganj",
                    OutletCode = "F361",
                    IpAddress = "172.17.161.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 385,
                    OutletName = "Shah Shuja Road N.ganj",
                    OutletCode = "F362",
                    IpAddress = "172.17.162.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 386,
                    OutletName = "Daiamoi Mor Jamalpur",
                    OutletCode = "F363",
                    IpAddress = "172.17.163.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 387,
                    OutletName = "Palshbari Ashulia",
                    OutletCode = "F364",
                    IpAddress = "172.17.164.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 388,
                    OutletName = "Belkuchi Sirajganj",
                    OutletCode = "F365",
                    IpAddress = "172.17.165.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 389,
                    OutletName = "Chitalmari Bagerhat",
                    OutletCode = "F366",
                    IpAddress = "172.17.166.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 390,
                    OutletName = "Charfasson Bhola",
                    OutletCode = "F367",
                    IpAddress = "172.17.167.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 391,
                    OutletName = "Garib Shah Sarak Jashore",
                    OutletCode = "F368",
                    IpAddress = "172.17.168.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 392,
                    OutletName = "Nasirabad 2nd gate CTG",
                    OutletCode = "F369",
                    IpAddress = "172.17.169.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 393,
                    OutletName = "Monipur Mirpur",
                    OutletCode = "F370",
                    IpAddress = "172.17.170.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 394,
                    OutletName = "Norda",
                    OutletCode = "F371",
                    IpAddress = "172.17.171.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 395,
                    OutletName = "Chuadanga",
                    OutletCode = "F372",
                    IpAddress = "172.17.172.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 396,
                    OutletName = "Khalifa Ghat Kamrangichar",
                    OutletCode = "F373",
                    IpAddress = "172.17.173.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 397,
                    OutletName = "Jirani Savar",
                    OutletCode = "F374",
                    IpAddress = "172.17.174.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 398,
                    OutletName = "Thakurgaon Road",
                    OutletCode = "F375",
                    IpAddress = "172.17.175.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 399,
                    OutletName = "Bhuighar NG",
                    OutletCode = "F376",
                    IpAddress = "172.17.176.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 400,
                    OutletName = "Taraboniar Chara Coxsbazar",
                    OutletCode = "F377",
                    IpAddress = "172.17.177.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 401,
                    OutletName = "Kazibari Gazipur",
                    OutletCode = "F378",
                    IpAddress = "172.17.178.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 402,
                    OutletName = "Dumki Patuakhal",
                    OutletCode = "F379",
                    IpAddress = "172.17.179.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 403,
                    OutletName = "East Hazipara Bou Bazar",
                    OutletCode = "F380",
                    IpAddress = "172.17.180.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 404,
                    OutletName = "Nilphamary Sadar",
                    OutletCode = "F381",
                    IpAddress = "172.17.181.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 405,
                    OutletName = "Grand Hotel Mor Rangpur",
                    OutletCode = "F382",
                    IpAddress = "172.17.182.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 406,
                    OutletName = "Jinjira Keraniganj",
                    OutletCode = "F383",
                    IpAddress = "172.17.183.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 407,
                    OutletName = "Balashur Bagghakul Sreenagar",
                    OutletCode = "F384",
                    IpAddress = "172.17.184.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 408,
                    OutletName = "Paragram Nawabgonj",
                    OutletCode = "F385",
                    IpAddress = "172.17.185.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 409,
                    OutletName = "Bangalipur Sayedpur",
                    OutletCode = "F386",
                    IpAddress = "172.17.186.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 410,
                    OutletName = "Siddik Road Gazipur",
                    OutletCode = "F388",
                    IpAddress = "172.17.188.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 411,
                    OutletName = "Banashree B Block",
                    OutletCode = "F389",
                    IpAddress = "172.17.189.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 412,
                    OutletName = "Court Road B.Baria",
                    OutletCode = "F390",
                    IpAddress = "172.17.190.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 413,
                    OutletName = "Nobodoy Housing Md.pur",
                    OutletCode = "F391",
                    IpAddress = "172.17.191.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 414,
                    OutletName = "Jawarshara",
                    OutletCode = "F392",
                    IpAddress = "172.17.192.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 415,
                    OutletName = "Gafargaon Mymensingh",
                    OutletCode = "F393",
                    IpAddress = "172.17.193.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 416,
                    OutletName = "Akbarshah  CTG",
                    OutletCode = "F394",
                    IpAddress = "172.17.194.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 417,
                    OutletName = "Meherpur Sadar",
                    OutletCode = "F395",
                    IpAddress = "172.17.195.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 418,
                    OutletName = "Jirani- 2 Savar",
                    OutletCode = "F396",
                    IpAddress = "172.17.196.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 419,
                    OutletName = "Sipahibagh",
                    OutletCode = "F397",
                    IpAddress = "172.17.197.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 420,
                    OutletName = "Bamundi Meherpur",
                    OutletCode = "F398",
                    IpAddress = "172.17.198.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 421,
                    OutletName = "Chandra Polli Biddut",
                    OutletCode = "F399",
                    IpAddress = "172.17.199.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 422,
                    OutletName = "Oxygen Mor Chattagram",
                    OutletCode = "F400",
                    IpAddress = "172.17.200.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 423,
                    OutletName = "Waspur Bosila",
                    OutletCode = "F401",
                    IpAddress = "172.17.201.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 424,
                    OutletName = "Patgram Lalmonirhat",
                    OutletCode = "F402",
                    IpAddress = "172.17.202.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 425,
                    OutletName = "Bolivadro Savar",
                    OutletCode = "F403",
                    IpAddress = "172.17.203.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 426,
                    OutletName = "Shilabristi Market, Kaliakoir",
                    OutletCode = "F405",
                    IpAddress = "172.17.205.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 427,
                    OutletName = "Kataikhana, Kustia",
                    OutletCode = "F406",
                    IpAddress = "172.17.206.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 428,
                    OutletName = "Katakhali Rajshahi",
                    OutletCode = "F407",
                    IpAddress = "172.17.207.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 429,
                    OutletName = "Khandar Bogura",
                    OutletCode = "F408",
                    IpAddress = "172.17.208.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 430,
                    OutletName = "Sujanagar Pabna",
                    OutletCode = "F409",
                    IpAddress = "172.17.209.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 431,
                    OutletName = "Sreepurbazar, Gazipur",
                    OutletCode = "F410",
                    IpAddress = "172.17.210.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 432,
                    OutletName = "Station Rd Sylhet",
                    OutletCode = "F411",
                    IpAddress = "172.17.211.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 433,
                    OutletName = "Mollahat Bagerhat",
                    OutletCode = "F412",
                    IpAddress = "172.17.212.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 434,
                    OutletName = "Surtaranga Road Tongi",
                    OutletCode = "F413",
                    IpAddress = "172.17.213.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 435,
                    OutletName = "Saturaia Manikganj",
                    OutletCode = "F414",
                    IpAddress = "172.17.214.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 436,
                    OutletName = "Pansha Rajbari",
                    OutletCode = "F415",
                    IpAddress = "172.17.215.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 437,
                    OutletName = "Sofiuddin school Rd,Auchpara Tongi",
                    OutletCode = "F416",
                    IpAddress = "172.17.216.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 438,
                    OutletName = "Amzad Ali School Rd Tongi",
                    OutletCode = "F417",
                    IpAddress = "172.17.217.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 439,
                    OutletName = "Borolekha Molovibazar",
                    OutletCode = "F418",
                    IpAddress = "172.17.218.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 440,
                    OutletName = "Ishwarganj Mymensingh",
                    OutletCode = "F419",
                    IpAddress = "172.17.219.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 441,
                    OutletName = "Panchabati Narayanganj",
                    OutletCode = "F420",
                    IpAddress = "172.17.220.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 442,
                    OutletName = "Juri Moulvibazar",
                    OutletCode = "F421",
                    IpAddress = "172.17.221.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 443,
                    OutletName = "C -Block  Pallabi",
                    OutletCode = "F422",
                    IpAddress = "172.17.222.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 444,
                    OutletName = "Malibagh railgate",
                    OutletCode = "F423",
                    IpAddress = "172.17.223.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 445,
                    OutletName = "Purbachal Road Uttar road",
                    OutletCode = "F424",
                    IpAddress = "172.17.224.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 446,
                    OutletName = "Ranisangkor Thakurgaon",
                    OutletCode = "F425",
                    IpAddress = "172.17.225.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 447,
                    OutletName = "South Banasree J block",
                    OutletCode = "F426",
                    IpAddress = "172.17.226.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 448,
                    OutletName = "Basherpool Demra",
                    OutletCode = "F427",
                    IpAddress = "172.17.227.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 449,
                    OutletName = "Puran Chandgaon",
                    OutletCode = "F428",
                    IpAddress = "172.17.228.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 450,
                    OutletName = "Bhola Sadar",
                    OutletCode = "F429",
                    IpAddress = "172.17.229.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 451,
                    OutletName = "Lalmohon Bhola",
                    OutletCode = "F430",
                    IpAddress = "172.17.230.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 452,
                    OutletName = "Morolganj Bagerhat",
                    OutletCode = "F431",
                    IpAddress = "172.17.231.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 453,
                    OutletName = "Bakerganj Barishal",
                    OutletCode = "F432",
                    IpAddress = "172.17.232.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 454,
                    OutletName = "Chandraganj Lakshmipur",
                    OutletCode = "F433",
                    IpAddress = "172.17.233.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 455,
                    OutletName = "Chowdhurypara Khilgaon",
                    OutletCode = "F434",
                    IpAddress = "172.17.234.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 456,
                    OutletName = "Domar Nilphamari",
                    OutletCode = "F435",
                    IpAddress = "172.17.235.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 457,
                    OutletName = "Islampur, Jamalpur",
                    OutletCode = "F436",
                    IpAddress = "172.17.236.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 458,
                    OutletName = "Joina Bazar Gazipur",
                    OutletCode = "F437",
                    IpAddress = "172.17.237.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 459,
                    OutletName = "Vashantek Dhaka",
                    OutletCode = "F438",
                    IpAddress = "172.17.238.5",
                    ISPName = "CCL",
                    ISPPhone = "1841073044.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 460,
                    OutletName = "Potia Chattagram",
                    OutletCode = "F439",
                    IpAddress = "172.17.239.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 461,
                    OutletName = "Dashmina Patuakhali",
                    OutletCode = "F440",
                    IpAddress = "172.17.240.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 462,
                    OutletName = "Kolpolok CTG[Amber]",
                    OutletCode = "F441",
                    IpAddress = "172.17.241.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 463,
                    OutletName = "Shibganj Chapainawabganj",
                    OutletCode = "F442",
                    IpAddress = "172.17.242.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 464,
                    OutletName = "IUT Board Bazar Gazipur",
                    OutletCode = "F443",
                    IpAddress = "172.17.243.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 465,
                    OutletName = "Barek Mollar Mor",
                    OutletCode = "F444",
                    IpAddress = "172.17.244.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 466,
                    OutletName = "Lohagora Paduar Bazar",
                    OutletCode = "F445",
                    IpAddress = "172.17.245.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 467,
                    OutletName = "Nabinagar Housing",
                    OutletCode = "F447",
                    IpAddress = "172.17.246.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 468,
                    OutletName = "Sadarpur Faridpur",
                    OutletCode = "F448",
                    IpAddress = "172.17.248.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 469,
                    OutletName = "BIDC Bazar Gazipur",
                    OutletCode = "F450",
                    IpAddress = "172.17.250.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 470,
                    OutletName = "Akhrabazar Kisharganj",
                    OutletCode = "F451",
                    IpAddress = "172.17.251.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 471,
                    OutletName = "Mosjid Road Gazipur",
                    OutletCode = "F452",
                    IpAddress = "172.17.252.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 472,
                    OutletName = "Momenbagh Demra Dhaka",
                    OutletCode = "F453",
                    IpAddress = "172.17.253.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 473,
                    OutletName = "Gazipura Bus Stnd Tongi 27",
                    OutletCode = "F454",
                    IpAddress = "172.17.254.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 474,
                    OutletName = "Dimla Nilphamari",
                    OutletCode = "F455",
                    IpAddress = "172.17.255.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 475,
                    OutletName = "Court More, Shariatpur",
                    OutletCode = "F456",
                    IpAddress = "172.19.56.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 476,
                    OutletName = "kumarkhali kushtia",
                    OutletCode = "F457",
                    IpAddress = "172.19.57.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 477,
                    OutletName = "Moynamoti, Cumilla",
                    OutletCode = "F458",
                    IpAddress = "172.19.58.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 478,
                    OutletName = "Mugdha Bazar",
                    OutletCode = "F459",
                    IpAddress = "172.19.59.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 479,
                    OutletName = "Noorer Chala Vatara",
                    OutletCode = "F460",
                    IpAddress = "172.19.60.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 480,
                    OutletName = "Shuihari Chowrangi Dinajpur",
                    OutletCode = "F461",
                    IpAddress = "172.19.61.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 481,
                    OutletName = "Dhamari Dhaka[Circle]",
                    OutletCode = "F462",
                    IpAddress = "172.19.62.5",
                    ISPName = "CCL",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 482,
                    OutletName = "Bhuyanbari Mor Madaripur",
                    OutletCode = "F463",
                    IpAddress = "172.19.63.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 483,
                    OutletName = "RP Gate Rajendrapur Gazipur",
                    OutletCode = "F464",
                    IpAddress = "172.19.64.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 484,
                    OutletName = "Milk Vita, Mirpur 11",
                    OutletCode = "F465",
                    IpAddress = "172.19.65.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 485,
                    OutletName = "mohajon patti, Bhola",
                    OutletCode = "F466",
                    IpAddress = "172.19.66.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 486,
                    OutletName = "Galachipa Patuakhali",
                    OutletCode = "F467",
                    IpAddress = "172.19.67.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 487,
                    OutletName = "Tushvhandar Lalmonirhat",
                    OutletCode = "F468",
                    IpAddress = "172.19.68.5",
                    ISPName = "ADN",
                    ISPPhone = "16615.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 488,
                    OutletName = "S A Tower, Gazirchot, Ashulia",
                    OutletCode = "F469",
                    IpAddress = "172.19.69.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 489,
                    OutletName = "Lalmai Cumilla",
                    OutletCode = "F471",
                    IpAddress = "172.19.71.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 490,
                    OutletName = "Niribili Nobinagar",
                    OutletCode = "F472",
                    IpAddress = "172.19.72.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 491,
                    OutletName = "Gurudaspur Natore",
                    OutletCode = "F473",
                    IpAddress = "172.19.73.5",
                    ISPName = "Amber",
                    ISPPhone = "8001111111.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 492,
                    OutletName = "Gangni Meherpur",
                    OutletCode = "F474",
                    IpAddress = "172.19.74.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 493,
                    OutletName = "Kulaura Moulvibazar",
                    OutletCode = "F475",
                    IpAddress = "172.19.75.5",
                    ISPName = "Drick",
                    ISPPhone = "1755500066.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 494,
                    OutletName = "Megula Bazar, Dohar",
                    OutletCode = "F476",
                    IpAddress = "172.19.76.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 495,
                    OutletName = "Kadamtola Basabo",
                    OutletCode = "F477",
                    IpAddress = "172.19.77.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 496,
                    OutletName = "Baroipara, Savar Ashulia",
                    OutletCode = "F478",
                    IpAddress = "172.19.78.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 497,
                    OutletName = "Nirala Khulna",
                    OutletCode = "F479",
                    IpAddress = "172.19.79.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 498,
                    OutletName = "Doulothkhan Bhola",
                    OutletCode = "F480",
                    IpAddress = "172.19.80.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 499,
                    OutletName = "Uttara-12",
                    OutletCode = "F481",
                    IpAddress = "172.19.81.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 500,
                    OutletName = "Jhitka Manikganj",
                    OutletCode = "F482",
                    IpAddress = "172.19.82.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 501,
                    OutletName = "Kutubkahli Jatrabari",
                    OutletCode = "F483",
                    IpAddress = "172.19.83.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 502,
                    OutletName = "Jurain",
                    OutletCode = "F484",
                    IpAddress = "172.19.84.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 503,
                    OutletName = "Chad uddan Mohammadpur",
                    OutletCode = "F485",
                    IpAddress = "172.19.85.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 504,
                    OutletName = "Panirkal Halishahar Ctg",
                    OutletCode = "F486",
                    IpAddress = "172.19.86.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 505,
                    OutletName = "Manikdi",
                    OutletCode = "F487",
                    IpAddress = "172.19.87.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 506,
                    OutletName = "Imandpur Savar",
                    OutletCode = "F488",
                    IpAddress = "172.19.88.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 507,
                    OutletName = "Tangail Bus Stand",
                    OutletCode = "F489",
                    IpAddress = "172.19.89.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 508,
                    OutletName = "Chakraborty Tek Gazipur",
                    OutletCode = "F490",
                    IpAddress = "172.19.90.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 509,
                    OutletName = "Motlab Chandpur",
                    OutletCode = "F491",
                    IpAddress = "172.19.91.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 510,
                    OutletName = "Cheragali Gazipur",
                    OutletCode = "F492",
                    IpAddress = "172.19.92.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 511,
                    OutletName = "Taherpur Rajshahi",
                    OutletCode = "F493",
                    IpAddress = "172.19.93.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 512,
                    OutletName = "Paker Matha Rangpur",
                    OutletCode = "F494",
                    IpAddress = "172.19.94.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 513,
                    OutletName = "Gunagari Bazar Chittagong",
                    OutletCode = "F495",
                    IpAddress = "172.19.95.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 514,
                    OutletName = "Kanaighat Sylhet",
                    OutletCode = "F496",
                    IpAddress = "172.19.96.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 515,
                    OutletName = "South Badda Dhaka",
                    OutletCode = "F497",
                    IpAddress = "172.19.97.5",
                    ISPName = "Agni",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 516,
                    OutletName = "Sonagazi Feni",
                    OutletCode = "F498",
                    IpAddress = "172.19.98.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 517,
                    OutletName = "Fultola Bazar Dohar",
                    OutletCode = "F499",
                    IpAddress = "172.19.99.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 518,
                    OutletName = "Barkat Sarani Joydebpur",
                    OutletCode = "F500",
                    IpAddress = "172.19.100.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 519,
                    OutletName = "Dhupkhola Bazar",
                    OutletCode = "F501",
                    IpAddress = "172.19.101.5",
                    ISPName = "Circle",
                    ISPPhone = "1615002223.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 520,
                    OutletName = "Rani Bazar Cumilla",
                    OutletCode = "F502",
                    IpAddress = "172.19.102.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 521,
                    OutletName = "Maijdee Bazar Noakhali",
                    OutletCode = "F503",
                    IpAddress = "172.19.103.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 522,
                    OutletName = "Babuganj Barishal",
                    OutletCode = "F504",
                    IpAddress = "172.19.104.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 523,
                    OutletName = "Rajarhat Kurigram",
                    OutletCode = "F505",
                    IpAddress = "172.19.105.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 524,
                    OutletName = "Block-D Mirpur 15",
                    OutletCode = "F506",
                    IpAddress = "172.19.106.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 525,
                    OutletName = "Cumilla Court Bari",
                    OutletCode = "F507",
                    IpAddress = "172.19.107.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 526,
                    OutletName = "Ullapara Sirajganj",
                    OutletCode = "F508",
                    IpAddress = "172.19.108.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 527,
                    OutletName = "Debiganj Panchagarh",
                    OutletCode = "F509",
                    IpAddress = "172.19.109.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 528,
                    OutletName = "Nalta Kaliganj Satkhira",
                    OutletCode = "F510",
                    IpAddress = "172.19.110.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 529,
                    OutletName = "Alauddin Road Nazirabazar",
                    OutletCode = "F511",
                    IpAddress = "172.19.111.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 530,
                    OutletName = "Grosthan Road Patuakhali",
                    OutletCode = "F512",
                    IpAddress = "172.19.112.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 531,
                    OutletName = "Gorai Bazar Tangail",
                    OutletCode = "F513",
                    IpAddress = "172.19.113.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 532,
                    OutletName = "Kashipur Bazar Barishal",
                    OutletCode = "F514",
                    IpAddress = "172.19.114.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 533,
                    OutletName = "Chandrima Town",
                    OutletCode = "F515",
                    IpAddress = "172.19.115.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 534,
                    OutletName = "Kulaura Moulvibazar",
                    OutletCode = "F516",
                    IpAddress = "172.19.116.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 535,
                    OutletName = "Ghior Manikganj",
                    OutletCode = "F517",
                    IpAddress = "172.19.117.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 536,
                    OutletName = "Bashbari Mohammadpur",
                    OutletCode = "F518",
                    IpAddress = "172.19.118.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 537,
                    OutletName = "Poduar Bazar Cumilla",
                    OutletCode = "F519",
                    IpAddress = "172.19.119.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 538,
                    OutletName = "Rajapur Bazar Jhalokathi",
                    OutletCode = "F520",
                    IpAddress = "172.19.120.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 539,
                    OutletName = "Griddakalindia Faridganj Chandpur",
                    OutletCode = "F521",
                    IpAddress = "172.19.121.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 540,
                    OutletName = "Hatimmara Bazar Kashimpur Gazipur",
                    OutletCode = "F522",
                    IpAddress = "172.19.122.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 541,
                    OutletName = "Shopno Nagar Abashik Pallabi",
                    OutletCode = "F523",
                    IpAddress = "172.19.123.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 542,
                    OutletName = "Box Culvert Road Panthapath Dhaka",
                    OutletCode = "F524",
                    IpAddress = "172.19.124.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 543,
                    OutletName = "Bisic Bridge, Gopalganj",
                    OutletCode = "F525",
                    IpAddress = "172.19.125.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 544,
                    OutletName = "Jaldhaka Nilphamari",
                    OutletCode = "F526",
                    IpAddress = "172.19.126.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 545,
                    OutletName = "Paurashava Road Patuakhali",
                    OutletCode = "F527",
                    IpAddress = "172.19.127.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 546,
                    OutletName = "Baniarchang Habiganj",
                    OutletCode = "F528",
                    IpAddress = "172.19.128.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 547,
                    OutletName = "Rangamati Outlet",
                    OutletCode = "F530",
                    IpAddress = "172.19.130.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 548,
                    OutletName = "Sunamgonj Trafic point",
                    OutletCode = "F531",
                    IpAddress = "172.19.131.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 549,
                    OutletName = "Janata Housing Mirpur 1",
                    OutletCode = "F532",
                    IpAddress = "172.19.132.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 550,
                    OutletName = "Shawropkathi Pirojpur",
                    OutletCode = "F533",
                    IpAddress = "172.19.133.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 551,
                    OutletName = "Panchar Bazar Madaripur",
                    OutletCode = "F534",
                    IpAddress = "172.19.134.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 552,
                    OutletName = "Kalampur Dhamrai",
                    OutletCode = "F535",
                    IpAddress = "172.19.135.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 553,
                    OutletName = "Kawla Namapara, Uttara Dhaka",
                    OutletCode = "F536",
                    IpAddress = "172.19.136.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 554,
                    OutletName = "Charmuguria, Madaripur sadar",
                    OutletCode = "F537",
                    IpAddress = "172.19.137.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 555,
                    OutletName = "golam Bazar, zinzira",
                    OutletCode = "F538",
                    IpAddress = "172.19.138.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 556,
                    OutletName = "Hafiznagar Khulna",
                    OutletCode = "F539",
                    IpAddress = "172.19.139.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 557,
                    OutletName = "Dalal Bazar Laxmipur",
                    OutletCode = "F540",
                    IpAddress = "172.19.140.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 558,
                    OutletName = "Singair Maniknaganj",
                    OutletCode = "F541",
                    IpAddress = "172.19.141.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 559,
                    OutletName = "Baufall Patuakhali",
                    OutletCode = "F542",
                    IpAddress = "172.19.142.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 560,
                    OutletName = "Police Mart Sirajganj",
                    OutletCode = "F543",
                    IpAddress = "172.19.143.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 561,
                    OutletName = "Parbotipur Dinajpur",
                    OutletCode = "F544",
                    IpAddress = "172.19.144.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 562,
                    OutletName = "Osmani Nagar Sylhet",
                    OutletCode = "F545",
                    IpAddress = "172.19.145.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 563,
                    OutletName = "CO Bazar Rangpur Sadar",
                    OutletCode = "F546",
                    IpAddress = "172.19.146.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 564,
                    OutletName = "Hetalia Badghat Patuakhali Sadar",
                    OutletCode = "F547",
                    IpAddress = "172.19.147.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 565,
                    OutletName = "Bhira Pabna",
                    OutletCode = "F548",
                    IpAddress = "172.19.148.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 566,
                    OutletName = "Etakhola Kazipara Dhaka",
                    OutletCode = "F549",
                    IpAddress = "172.19.149.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 567,
                    OutletName = "Bashurhat Noakhali",
                    OutletCode = "F550",
                    IpAddress = "172.19.150.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 568,
                    OutletName = "Maniknagar Mugda Dhaka",
                    OutletCode = "F551",
                    IpAddress = "172.19.151.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 569,
                    OutletName = "Bosila RAB HQ",
                    OutletCode = "F552",
                    IpAddress = "172.19.152.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 570,
                    OutletName = "Bakalia access road Chittagong",
                    OutletCode = "F553",
                    IpAddress = "172.19.153.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 571,
                    OutletName = "Police Line Feni",
                    OutletCode = "F554",
                    IpAddress = "172.19.154.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 572,
                    OutletName = "DIT Project, Merul Badda",
                    OutletCode = "F555",
                    IpAddress = "172.19.155.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 573,
                    OutletName = "Sardarbari Dakshin Khan Dhaka",
                    OutletCode = "F556",
                    IpAddress = "172.19.156.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 574,
                    OutletName = "K. C. Road Ulipur Kurigram",
                    OutletCode = "F557",
                    IpAddress = "172.19.157.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 575,
                    OutletName = "Rajpat Kashiani Gopalganj",
                    OutletCode = "F558",
                    IpAddress = "172.19.158.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 576,
                    OutletName = "Mandari Bazar Laxmipur",
                    OutletCode = "F559",
                    IpAddress = "172.19.159.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 577,
                    OutletName = "Dalal Bazar Laxmipur",
                    OutletCode = "F540",
                    IpAddress = "172.19.140.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 578,
                    OutletName = "Bakalia access road Ctg",
                    OutletCode = "F553",
                    IpAddress = "172.19.153.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 579,
                    OutletName = "Banara Mouchak Gazipur",
                    OutletCode = "F564",
                    IpAddress = "172.19.164.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 580,
                    OutletName = "Dhamura Bazar Barishal",
                    OutletCode = "F570",
                    IpAddress = "172.19.170.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 581,
                    OutletName = "Baluchara CTG",
                    OutletCode = "F568",
                    IpAddress = "172.19.168.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 582,
                    OutletName = "Prosika Mor Mawna",
                    OutletCode = "F561",
                    IpAddress = "172.19.161.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 583,
                    OutletName = "Shaw Raod Barishal",
                    OutletCode = "F569",
                    IpAddress = "172.19.169.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 584,
                    OutletName = "Miabari Raod Kuril",
                    OutletCode = "F575",
                    IpAddress = "172.19.175.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 585,
                    OutletName = "Monohordi Bazar, Narshingdi",
                    OutletCode = "F581",
                    IpAddress = "172.19.181.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 586,
                    OutletName = "Dholpur Uttar Jatrabari",
                    OutletCode = "F576",
                    IpAddress = "172.19.176.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 587,
                    OutletName = "Shahjaha Sir Rd Hazaribagh",
                    OutletCode = "F574",
                    IpAddress = "172.19.174.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 588,
                    OutletName = "Boalmari Faridpur",
                    OutletCode = "F577",
                    IpAddress = "172.19.177.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 589,
                    OutletName = "Islamnagar Jahangirngar University Area",
                    OutletCode = "F582",
                    IpAddress = "172.19.182.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 590,
                    OutletName = "Bhanga Faridpur",
                    OutletCode = "F585",
                    IpAddress = "172.19.185.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 591,
                    OutletName = "Bottola Masjid Manda",
                    OutletCode = "F579",
                    IpAddress = "172.19.179.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 592,
                    OutletName = "Pakullah Tangail",
                    OutletCode = "F586",
                    IpAddress = "172.19.186.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 593,
                    OutletName = "Sapnodhara Housing Bosila",
                    OutletCode = "F578",
                    IpAddress = "172.19.178.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 594,
                    OutletName = "Dhali Bari Bazar Vatara",
                    OutletCode = "F588",
                    IpAddress = "172.19.188.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 595,
                    OutletName = "T & T or DIT Bazar Tongi",
                    OutletCode = "F565",
                    IpAddress = "172.19.165.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 596,
                    OutletName = "Kamar Mor, Rangpur Sadar",
                    OutletCode = "F560",
                    IpAddress = "172.19.160.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 597,
                    OutletName = "West Dholaipar Juktibadi Goli",
                    OutletCode = "F571",
                    IpAddress = "172.19.171.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 598,
                    OutletName = "Bank Colony Savar",
                    OutletCode = "F584",
                    IpAddress = "172.19.184.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 599,
                    OutletName = "Bolorawa Bazar Harirampur",
                    OutletCode = "F587",
                    IpAddress = "172.19.187.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 600,
                    OutletName = "Singair Maniknaganj Outlet",
                    OutletCode = "F541",
                    IpAddress = "172.19.141.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 601,
                    OutletName = "Banashree G Block Outlet",
                    OutletCode = "F591",
                    IpAddress = "172.19.191.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 602,
                    OutletName = "Bhawal Mirzapur",
                    OutletCode = "F572",
                    IpAddress = "172.19.172.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 603,
                    OutletName = "Haiderganj Lashkmipur",
                    OutletCode = "F566",
                    IpAddress = "172.19.166.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 604,
                    OutletName = "Savar Bazar Bus Stand",
                    OutletCode = "F562",
                    IpAddress = "172.19.162.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 605,
                    OutletName = "Saddam Market Tushar Bari",
                    OutletCode = "F583",
                    IpAddress = "172.19.183.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 606,
                    OutletName = "Chatmohar Pabna",
                    OutletCode = "F589",
                    IpAddress = "172.19.189.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 607,
                    OutletName = "Tetulia Panchagar",
                    OutletCode = "F590",
                    IpAddress = "172.19.190.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 608,
                    OutletName = "Shankar West Dhanmondi",
                    OutletCode = "F592",
                    IpAddress = "172.19.192.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 609,
                    OutletName = "Hemayetpur Bazar Bus Stand",
                    OutletCode = "F593",
                    IpAddress = "172.19.193.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 610,
                    OutletName = "Torki Bandar Gouranadi Barisal",
                    OutletCode = "F600",
                    IpAddress = "172.19.200.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 611,
                    OutletName = "Choto Bazar Netrokona",
                    OutletCode = "F243",
                    IpAddress = "172.15.243.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 612,
                    OutletName = "Pagla Kanai Jhenaidha",
                    OutletCode = "F604",
                    IpAddress = "172.19.204.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 613,
                    OutletName = "Khagrachari",
                    OutletCode = "F567",
                    IpAddress = "172.19.167.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 614,
                    OutletName = "Rayerbazar Dhanmondi Dhaka",
                    OutletCode = "F597",
                    IpAddress = "172.19.197.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 615,
                    OutletName = "Bhatiari Chattagram",
                    OutletCode = "F610",
                    IpAddress = "172.19.210.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 616,
                    OutletName = "Chawkbazar Chttagram",
                    OutletCode = "F609",
                    IpAddress = "172.19.209.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 617,
                    OutletName = "Sorikol Bazar Gouranadi Barisal",
                    OutletCode = "F607",
                    IpAddress = "172.19.207.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 618,
                    OutletName = "Roumari Kurigram",
                    OutletCode = "F605",
                    IpAddress = "172.19.205.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 619,
                    OutletName = "Madaripur Puran Bazar",
                    OutletCode = "F608",
                    IpAddress = "172.19.208.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 620,
                    OutletName = "Sonagazi Outlet Feni",
                    OutletCode = "F498",
                    IpAddress = "172.19.198.5",
                    ISPName = "KS",
                    ISPPhone = "1733347591.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 621,
                    OutletName = "Banshree C Block",
                    OutletCode = "F595",
                    IpAddress = "172.19.195.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 622,
                    OutletName = "Lebukhali Pagla Mor Patuakhali",
                    OutletCode = "F611",
                    IpAddress = "172.19.211.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 623,
                    OutletName = "Natiapara Tangail",
                    OutletCode = "F612",
                    IpAddress = "172.19.212.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 624,
                    OutletName = "Baufall Patuakhali",
                    OutletCode = "F542",
                    IpAddress = "172.19.142.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 625,
                    OutletName = "Raipur Lakshmipur",
                    OutletCode = "F573",
                    IpAddress = "172.19.173.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 626,
                    OutletName = "Shantibagh Demra",
                    OutletCode = "F613",
                    IpAddress = "172.19.213.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 627,
                    OutletName = "Baghbari Lakshmipur",
                    OutletCode = "F614",
                    IpAddress = "172.19.214.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 628,
                    OutletName = "Kachari Bazar Rangpur",
                    OutletCode = "F602",
                    IpAddress = "172.19.202.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 629,
                    OutletName = "Brammonchiron Dholpur Dhaka",
                    OutletCode = "F606",
                    IpAddress = "172.19.206.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 630,
                    OutletName = "Sultan Market Sardarganj",
                    OutletCode = "F599",
                    IpAddress = "172.19.199.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                },

                new Outlet
                {
                    Id = 631,
                    OutletName = "Kunjerhat Bhola",
                    OutletCode = "F598",
                    IpAddress = "172.19.198.5",
                    ISPName = "Circle",
                    ISPPhone = "1944443331.0",
                    LastPingStatus = "Not checked",
                    LastPingTime = null
                }
            );
        }
    }
} 

