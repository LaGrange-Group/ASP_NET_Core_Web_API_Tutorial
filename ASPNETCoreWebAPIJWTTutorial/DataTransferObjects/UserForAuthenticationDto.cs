using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreWebAPIJWTTutorial.DataTransferObjects
{
    public class UserForAuthenticationDto
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}
