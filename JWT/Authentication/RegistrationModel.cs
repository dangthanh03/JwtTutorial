using System.ComponentModel.DataAnnotations;

namespace JWT.Authentication
{
    public class RegistrationModel
    {
        public required string Username {  get; set; }
        public string Password { get; set; }

        [EmailAddress]
        public required string Email { get; set; }   
    }
}
