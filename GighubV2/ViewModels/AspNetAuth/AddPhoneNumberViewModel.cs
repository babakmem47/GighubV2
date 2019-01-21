using System.ComponentModel.DataAnnotations;

namespace GighubV2.ViewModels.AspNetAuth
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}