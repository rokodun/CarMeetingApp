﻿using CarMeeting.Data;
using CarMeeting.Web.ViewModels.Event;
using CarMeetinig.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using static CarMeeting.Common.EntityValidationConstants.Event;

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
                .ToArray();

            return View(events);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddEventInputModel inputModel)
        {
            bool isDateValid = DateTime.
                TryParseExact(inputModel.Date, EventDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime eventDate);

            if (!isDateValid)
            {
                ModelState.AddModelError(nameof(inputModel.Date), "Date must be in the following format: dd/MM/yyyy");
            }

            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            Event @event = new Event()
            {
                Name = inputModel.Name,
                Date = eventDate,
                Location = inputModel.Location,
                Description = inputModel.Description
            };
            dbContext.Events.Add(@event);
            dbContext.SaveChanges();

            TempData["SuccessMessage"] = "Event has been successfully created!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            bool isIdValid = Guid.TryParse(id, out Guid idValid);

            if (!isIdValid)
            {
                return RedirectToAction(nameof(Index));
            }

            Event? @event = dbContext
                .Events
                .FirstOrDefault(e => e.Id == idValid);

            if (@event == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(@event);
        }
    }
}
