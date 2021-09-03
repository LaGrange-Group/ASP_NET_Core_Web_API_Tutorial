using Microsoft.AspNetCore.Identity;

namespace ASPNETCoreWebAPIJWTTutorial.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
