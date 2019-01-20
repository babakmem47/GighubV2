using GighubV2.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GighubV2.Controllers.Api
{
    [Authorize]
    public class GigsController : ApiController
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var currentUserId = User.Identity.GetUserId();
            var gig = _context.Gigs.Single(g => g.Id == id && g.ArtistId == currentUserId);
            
            if (gig.IsCanceled)
                return NotFound();

            gig.IsCanceled = true;
            _context.SaveChanges();
        
            return Ok();
        }

        [HttpGet]
        public IEnumerable<Gig> GetAllGigs()
        {
            var currentUserId = User.Identity.GetUserId();
            var gigs = _context.Gigs
                .Where(g => g.ArtistId == currentUserId)
                .ToList();
            return gigs;
        }
    }
}
