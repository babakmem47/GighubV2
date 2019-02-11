using AutoMapper;
using GighubV2.Dtos;
using GighubV2.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace GighubV2.Controllers.Api
{
    [Authorize]
    public class NotificationsController : ApiController
    {
        private ApplicationDbContext _context;

        public NotificationsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<NotificationDto> GetNewNotifications()
        {
            var currentUserId = User.Identity.GetUserId();
            var notifications = _context.UserNotifications
                .Where(un => un.UserId == currentUserId && !un.IsRead)
                .Select(un => un.Notification)
                .Include(n => n.Gig.Artist)
                .Include(n => n.Gig.Genre)
                .ToList();

            return notifications.Select(Mapper.Map<Notification, NotificationDto>);
        }

        [HttpPost]
        public IHttpActionResult MarkAsRead()
        {
            var currentUserId = User.Identity.GetUserId();
            var notifications = _context.UserNotifications
                .Where(un => un.UserId == currentUserId && !un.IsRead)
                .ToList();

            notifications.ForEach(n => n.Read());

            _context.SaveChanges();

            return Ok("successfully mark " + notifications.Count + " unread notifications for current user as read");
        }
    }
}
