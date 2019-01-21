using System.ComponentModel.DataAnnotations;

namespace GighubV2.ViewModels.AspNetAuth
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
