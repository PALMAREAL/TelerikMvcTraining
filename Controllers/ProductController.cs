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
using TelerikMvcTraining.Data.Repositories;

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
