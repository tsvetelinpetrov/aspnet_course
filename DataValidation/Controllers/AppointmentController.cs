using DataValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataValidation.Controllers
{
    public class AppointmentController : Controller
    {

        List<AppointmentModel> appointments = new List<AppointmentModel>();

        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(AppointmentModel appointment)
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }
    }
}
