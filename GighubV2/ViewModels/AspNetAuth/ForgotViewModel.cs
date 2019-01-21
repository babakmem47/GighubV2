using System.ComponentModel.DataAnnotations;

namespace GighubV2.ViewModels.AspNetAuth
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}