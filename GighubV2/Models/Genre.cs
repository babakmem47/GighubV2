using System.ComponentModel.DataAnnotations;

namespace GighubV2.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}