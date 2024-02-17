using Task3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Task3.Controllers
{
    public class RegistrationController : Controller
    {
        List<SelectListItem> sub = new List<SelectListItem>
        {
            new SelectListItem {Text = "JavaScript", Value = "1"},
            new SelectListItem {Text = "C#", Value = "2"},
            new SelectListItem {Text = "Java", Value = "3"},
            new SelectListItem {Text = "Python", Value = "4"},
            new SelectListItem {Text = "Основи", Value = "5"}
        }; 


        [HttpGet]
        public IActionResult Registration()
        {
            ViewBag.Subjects = sub;
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationFormModel model)
        {

            if (model.Subject == "5" && model.RegistrationTime.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError(nameof(model.Subject), "Консультація щодо продукту «Основи» не може проходити по понеділках");
            }

            if (ModelState.IsValid)
            {
                Console.WriteLine($"В базу записаний користувач: {model.Name} {model.Surname} (email: {model.Email}, час прийому: {model.RegistrationTime})");
                return View("Success");
            }
            else
            {
                ViewBag.Subjects = sub;
                return View(model);
            }
        }
    }
}
