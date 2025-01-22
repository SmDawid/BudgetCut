using System.ComponentModel.DataAnnotations;

namespace MVCTemplate.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress] 
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }

        public DateTime LoginDateTime { get; set; } = DateTime.Now;
    }
}