using GighubV2.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace GighubV2.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(int gigId)
        {
            var currentUserId = User.Identity.GetUserId();
            var attendance = new Attendance
            {
                GigId = gigId,
                //                Gig = _context.Gigs.Single(g => g.Id == gigId),
                AttendeeId = currentUserId
                //                Attendee = _context.Attendances.Single(a => a.AttendeeId == currentUserId)
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
