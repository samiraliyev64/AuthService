using System.ComponentModel.DataAnnotations;

namespace AuthenticationService_test.Dtos
{
    public class UserLoginRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
