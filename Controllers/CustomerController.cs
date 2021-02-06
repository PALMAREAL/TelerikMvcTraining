using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TelerikMvcTraining.Data;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindDbContext db = new NorthwindDbContext();


        public ActionResult BasicAutocomplete()
        {
            return View();
        }

        public ActionResult ProAutocomplete()
        {
            return View();
        }

        public JsonResult GetCategories()
        {
            var categories = db.Categories.Select(c => new CategoryViewModel
            {
                CategoryIDVm = c.CategoryID,
                CategoryNameVm = c.CategoryName,
                DescriptionVm = c.Description
            });

            return Json(categories, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
