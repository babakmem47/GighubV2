using System.Collections.Generic;

namespace GighubV2.ViewModels.AspNetAuth
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}