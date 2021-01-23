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
        private NorthwindDbContext db = new NorthwindDbContext();


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
            var result = new ProductRepositoryMock(db).GetAllProducts();

            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult DetailProducts_Read([DataSourceRequest] DataSourceRequest request)
        {
            var result = new ProductRepositoryMock(db).GetAllDetailsProducts();

            return Json(result.ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult SalesByProductCategory()
        {
            return Json(ProductRepositoryMock.GetProductCategoriesData());
        }

        [HttpPost]
        public ActionResult FunnelSales()
        {
            return Json(ProductRepositoryMock.GetFunnelSalesData());
        }

        [HttpPost]
        public ActionResult SalesByRegion()
        {
            return Json(ProductRepositoryMock.GetRegionSalesData());
        }

        [HttpPost]
        public ActionResult SalesPerformers()
        {
            return Json(ProductRepositoryMock.GetSalesPerformers());
        }

        [HttpPost]
        public ActionResult BoeingStockDataRead()
        {
            return Json(ProductRepositoryMock.BoeingStockData());
        }

        public JsonResult Get_Categories()
        {
            return Json(ProductRepositoryMock.GetCategoriesData(), JsonRequestBehavior.AllowGet);
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
