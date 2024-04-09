using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }

        public ProductWithName Select(Func<object, ProductWithName> value)
        {
            throw new NotImplementedException();
        }
    }
}
