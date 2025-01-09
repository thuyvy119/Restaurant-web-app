using System.Collections;
using Microsoft.AspNetCore.Identity;

namespace Final_RestaurantWebApp.Models
{
    public class ApplicationUser : IdentityUser    
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
