using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace extraaedge.Models
{
    [Table("Brandname")]
    public class Brandname
    {
        [Key]
        public int Bid { get; set; }
       
        public string? Name { get; set; }
        

    }
}
