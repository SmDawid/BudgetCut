using System.ComponentModel.DataAnnotations;

namespace MVCTemplate.Models
{
    public class RegisterViewModel
    {
        [Required] //(ErrorMessage = "Adres e-mail jest wymagany")]
        [EmailAddress] //(ErrorMessage = "Nieprawidłowy format adresu e-mail")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}



