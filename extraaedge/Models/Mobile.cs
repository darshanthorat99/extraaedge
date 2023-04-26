using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace extraaedge.Models
{
    [Table("mobile")]
    public class Mobile
    {
        [Key]
        public int Mid { get; set; }
        [Required]
        public int Bid { get; set; }
        [Required]
        public string? Model { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
