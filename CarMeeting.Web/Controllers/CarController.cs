using CarMeeting.Data;
using CarMeeting.Data.Models;
using CarMeeting.Web.ViewModels.Car;
using Microsoft.AspNetCore.Mvc;

namespace CarMeeting.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly CarMeetingDbContext _context;

        public CarController(CarMeetingDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Car> cars = this._context
                .Cars
                .ToArray();

            return View(cars);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateCarViewModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            Car car = new Car
            {
                Id = Guid.NewGuid(),
                Make = inputModel.Make,
                Model = inputModel.Model,
                Year = inputModel.Year,
                Color = inputModel.Color
            };

            _context.Cars.Add(car);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Car has been successfully created!";
            return RedirectToAction(nameof(Index));
        }

    }
}
