using Microsoft.AspNetCore.Mvc;
using RegisterAndLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if(userModel.username == "tsetso" && userModel.password == "tsetso123")
            {
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }

            
        }
    }
}
