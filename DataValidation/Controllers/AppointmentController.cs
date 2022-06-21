using DataValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataValidation.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(AppointmentModel appointment)
        {
            return View("Details", appointment);
        }
    }
}
