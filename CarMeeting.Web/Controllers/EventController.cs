using CarMeeting.Data;
using CarMeetinig.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarMeeting.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly CarMeetingDbContext dbContext;

        public EventController(CarMeetingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> events = this.dbContext
                .Events
                .ToList();

            return View(events);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
