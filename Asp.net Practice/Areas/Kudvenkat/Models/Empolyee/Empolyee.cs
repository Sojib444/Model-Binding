using System.ComponentModel.DataAnnotations;

namespace Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee
{
    public class Empolyee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public string? Address { get; set; }
        public EnumEmpolyee  Department { get; set; }
    }
}
