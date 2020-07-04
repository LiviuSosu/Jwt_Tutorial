using System.ComponentModel.DataAnnotations;

namespace TokenDemoDonNetCore3._1.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
