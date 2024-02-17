using ASPNETCore_HomeTasks_8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace ASPNETCore_HomeTasks_8.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Registration()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationFormModel model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine($"В базу записаний користувач: {model.Name} {model.Surname} (email: {model.Email}, час прийому: {model.RegistrationTime})");
                return View("Success");
            }
            else
            {
                return View(model);
            }
        }
    }
}
