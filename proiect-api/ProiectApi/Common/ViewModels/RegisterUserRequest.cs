using System.ComponentModel.DataAnnotations;

namespace Common.ViewModels
{
    public class RegisterUserRequest
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }

    }
}
