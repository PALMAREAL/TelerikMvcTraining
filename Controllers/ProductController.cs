using System.Web.Mvc;
using TelerikMvcTraining.Data;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;
using System.Linq;
using System;

namespace TelerikMvcTraining.Controllers
{
    public class ProductController : Controller
    {
        private TelerikContext db = new TelerikContext();


        public ActionResult BasicGrid()
        {
            return View();
        }

        public ActionResult AdvancedGrid()
        {
            return View();
        }

        public ActionResult ProGrid()
        {
            return View();
        }

        public ActionResult BasicDropDownList()
        {
            return View();
        }

        public ActionResult AdvancedDropDownList()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = new ProductRepository(db).GetAllProducts();

            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult DetailProducts_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = new ProductRepository(db).GetAllDetailsProducts();

            return Json(result.ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult SalesByProductCategory()
        {
            return Json(ProductRepository.GetProductCategoriesData());
        }

        [HttpPost]
        public ActionResult FunnelSales()
        {
            return Json(ProductRepository.GetFunnelSalesData());
        }

        [HttpPost]
        public ActionResult SalesByRegion()
        {
            return Json(ProductRepository.GetRegionSalesData());
        }

        [HttpPost]
        public ActionResult SalesPerformers()
        {
            return Json(ProductRepository.GetSalesPerformers());
        }

        [HttpPost]
        public ActionResult BoeingStockDataRead()
        {
            return Json(ProductRepository.BoeingStockData());
        }

        public JsonResult Get_Categories()
        {
            return Json(ProductRepository.GetCategoriesData(), JsonRequestBehavior.AllowGet);
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
