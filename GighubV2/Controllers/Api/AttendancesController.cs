using System.Linq;
using System.Web.Http;
using GighubV2.Dtos;
using GighubV2.Models;
using Microsoft.AspNet.Identity;

namespace GighubV2.Controllers.Api
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
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var currentUserId = User.Identity.GetUserId();
            var alrearyExist = _context.Attendances.Any(a => a.AttendeeId == currentUserId && a.GigId == dto.GigId);
            if (alrearyExist)
            {
                return BadRequest("The attendance already exists."); 
            }

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                //                Gig = _context.Gigs.Single(g => g.Id == gigId),
                AttendeeId = currentUserId
                //                Attendee = _context.Attendances.Single(a => a.AttendeeId == currentUserId)
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ReturnAllAttendances()
        {
            var attendances = _context.Attendances.ToList();

            return Ok(attendances);
        }
    }
}
