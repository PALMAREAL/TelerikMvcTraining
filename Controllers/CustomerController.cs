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

namespace TelerikMvcTraining.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindDbContext db = new NorthwindDbContext();

        public ActionResult BasicChart()
        {
            return View();
        }

        public ActionResult AdvancedChart()
        {
            return View();
        }

        public ActionResult ProChart()
        {
            return View();
        }

        public ActionResult BasicDateRangePicker()
        {
            return View();
        }

        public ActionResult BasicAutocomplete()
        {
            return View();
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
