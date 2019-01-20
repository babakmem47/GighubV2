using System;
using GighubV2.Models;
using GighubV2.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace GighubV2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var upcomingGigs = _context.Gigs
                .Include(gg => gg.Artist)
                .Include(gg => gg.Genre)
                .Where(gg =>  !gg.IsCanceled);

            var viewModel = new GigsViewModel
            {
                UpcomingGigs = upcomingGigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Upcoming Gigs"
            };

            return View("Gigs", viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}