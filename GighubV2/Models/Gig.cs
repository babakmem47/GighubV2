using System;
using System.ComponentModel.DataAnnotations;

namespace GighubV2.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string Venue { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}