using System;
using GighubV2.Controllers.Api;

namespace GighubV2.Dtos
{
    public class GigDto
    {
        public int Id { get; set; }
        public UserDto Performer { get; set; }
        public DateTime DateTime { get; set; }
        public string Venue { get; set; }
        public GenreDto Genre { get; set; }

    }
}