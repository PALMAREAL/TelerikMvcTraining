using System.Web.Mvc;
using TelerikMvcTraining.Data;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using TelerikMvcTraining.Data.Repositories;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;
using System.Linq;
using System;
using TelerikMvcTraining.Services;

namespace TelerikMvcTraining.Controllers
{
    public class ProductController : Controller
    {
        //public IProductRepository ProductRepository { get; set; }

        public IProductService ProductService { get; set; }

        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }   

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProductService.GetAllProducts().ToDataSourceResult(request));
        }

        public ActionResult DetailProducts_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProductService.GetAllDetailsProducts().ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult SalesByProductCategory()
        {
            return Json(ProductService.GetProductCategoriesData());
        }

        [HttpPost]
        public ActionResult FunnelSales()
        {
            return Json(ProductService.GetFunnelSalesData());
        }

        [HttpPost]
        public ActionResult SalesByRegion()
        {
            return Json(ProductService.GetRegionSalesData());
        }

        [HttpPost]
        public ActionResult SalesPerformers()
        {
            return Json(ProductService.GetSalesPerformers());
        }

        [HttpPost]
        public ActionResult BoeingStockDataRead()
        {
            return Json(ProductService.BoeingStockData());
        }

        public JsonResult Get_Categories()
        {
            return Json(ProductService.GetCategoriesData(), JsonRequestBehavior.AllowGet);
        }
    }
}
