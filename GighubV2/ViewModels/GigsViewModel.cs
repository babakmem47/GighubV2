using System.Collections.Generic;
using GighubV2.Models;

namespace GighubV2.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
    }
}