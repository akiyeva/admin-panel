using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PB303Fashion.DataAccessLayer.Entities
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
      
    }
}
