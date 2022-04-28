using System.ComponentModel.DataAnnotations;

namespace Common.ViewModels
{
    public class LoginUserRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
