using Microsoft.AspNetCore.Identity;

namespace Mango.Services.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
