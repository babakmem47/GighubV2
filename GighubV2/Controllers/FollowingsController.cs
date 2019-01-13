using GighubV2.Dtos;
using GighubV2.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace GighubV2.Controllers
{
    [Authorize]
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _context;

        public FollowingsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            var currentUserId = User.Identity.GetUserId();
            var alreadyExist =
                _context.Followings.Any(f => f.FollowerId == currentUserId && f.FolloweeId == dto.ArtistId);
            if (alreadyExist)
            {
                return BadRequest("Following already Exists.");
            }

            var following = new Following()
            {
                FollowerId = currentUserId,
                FolloweeId = dto.ArtistId
            };

            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAllFollows()
        {
            var followList = _context.Followings.ToList();

            return Ok(followList);
        }
    }
}
