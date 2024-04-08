using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ECommerce.Models
{
    public class Product
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required] 
        public string Author { get; set; }
        [Required]
        [Display(Name = "Selling Price")]
        [Range(1,1000)]
        public double Price { get; set; }
    }
}
