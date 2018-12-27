using System;
using System.ComponentModel.DataAnnotations;

namespace GighubV2.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }

    }
}