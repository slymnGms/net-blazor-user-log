using System.ComponentModel.DataAnnotations;

namespace BlazorUserRegLog.Models.Account
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
