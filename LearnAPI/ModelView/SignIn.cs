using System.ComponentModel.DataAnnotations;

namespace LearnAPI.ModelView
{
    public class SignIn
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
