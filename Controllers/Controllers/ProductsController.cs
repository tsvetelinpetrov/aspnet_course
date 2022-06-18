using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View("Message");
        }

        public IActionResult Welcome(string name, int number)
        {
            ViewBag.Name = name;
            ViewBag.Number = number;

            return View();
        }
    }
}
