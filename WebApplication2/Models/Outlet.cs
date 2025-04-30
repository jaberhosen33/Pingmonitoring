using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Outlet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OutletName { get; set; }
        public string OutletCode { get; set; }
        public string IpAddress { get; set; }
        public string ISPName { get; set; }
        public string ISPPhone { get; set; }
        public string LastPingStatus { get; set; }
        public DateTime? LastPingTime { get; set; }
    }
}
