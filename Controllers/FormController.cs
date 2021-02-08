using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Controllers
{
    public class FormController : Controller
    {

        public ActionResult BasicForm()
        {
            return View(new UserViewModel()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@email.com",
                UserName = "johny",
                Password = "123456",
                DateOfBirth = new DateTime(1990, 5, 8),
                Agree = false
            });
        }

        [HttpPost]
        public ActionResult BasicForm(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TempData["View"] = "Index";
                return View("Success");
            }
        }

        public ActionResult Success()
        {
            ViewBag.View = TempData["View"];

            return View();
        }
    }
}
