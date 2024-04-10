using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace ECommerce.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int Name {  get; set; }
        public string? city { get; set; }
        public string? state { get; set; }   
        public string? zipcode { get; set; }
    }
}
