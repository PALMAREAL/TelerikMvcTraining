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
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Controllers
{
    public class ProductController : Controller
    {
        private TelerikContext db = new TelerikContext();


        public ActionResult BasicGrid()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {

            var result = Enumerable.Range(0, 50).Select(i => new ProductViewModel
            {
                ProductID = i,
                SupplierID = i + 1,
                ProductName = "SamsungTablet" + "  A." + (i*2),
                UnitPrice = i + 25,
                Discontinued = false,
                CategoryID = i + 2,
                QuantityPerUnit = (i + 10).ToString(),
                UnitsInStock = (uint?)(i + 3),
                UnitsOnOrder = (uint?)(i + 4),
                ReorderLevel = (uint?)(i + 20)
            });

            return Json(result.ToDataSourceResult(request));
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
