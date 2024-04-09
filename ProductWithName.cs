using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ProductWithName
    {
     
        public int BookId { get; set; }
  
        public string BookTitle { get; set; }
   
        public string Description { get; set; }
      
        public string ISBN { get; set; }
    
        public string Author { get; set; }
   
    
        public double Price { get; set; }

        public string CategoryName { get; set; }
     
        
    }
}
