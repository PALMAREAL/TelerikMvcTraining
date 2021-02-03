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
using AutoMapper;
using System.Collections.Generic;

namespace TelerikMvcTraining.Controllers
{
    public class ProductController : BaseController
    {
        public IProductService ProductService { get; set; }

        public ProductController(IProductService productService, IMapper mapper) : base (mapper)
        {
            ProductService = productService;
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            var products = ProductService.GetAllProducts();

            var productViewModel = Mapper.Map<IEnumerable<ProductViewModel>>(products);

            return Json(productViewModel.ToDataSourceResult(request));
        }

        public ActionResult DetailProducts_Read([DataSourceRequest] DataSourceRequest request)
        {
            var products = ProductService.GetAllDetailsProducts();

            var detailProductViewModel = Mapper.Map<IEnumerable<DetailProductViewModel>>(products);

            return Json(detailProductViewModel.ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult SalesByProductCategory()
        {
            var products = ProductService.GetProductCategoriesData();

            var productCategoriesViewModel = Mapper.Map<IEnumerable<ProductCategoriesViewModel>>(products);

            return Json(productCategoriesViewModel);
        }

        [HttpPost]
        public ActionResult FunnelSales()
        {
            var products = ProductService.GetFunnelSalesData();

            var funnelSalesViewModel = Mapper.Map<IEnumerable<FunnelSalesViewModel>>(products);

            return Json(funnelSalesViewModel);
        }

        [HttpPost]
        public ActionResult SalesByRegion()
        {
            var products = ProductService.GetRegionSalesData();

            var regionSalesViewModel = Mapper.Map<IEnumerable<RegionSalesViewModel>>(products);

            return Json(regionSalesViewModel);
        }

        [HttpPost]
        public ActionResult SalesPerformers()
        {
            var products = ProductService.GetSalesPerformers();

            var salesPerformersViewModel = Mapper.Map<IEnumerable<SalesPerformersViewModel>>(products);

            return Json(salesPerformersViewModel);
        }

        [HttpPost]
        public ActionResult BoeingStockDataRead()
        {
            var products = ProductService.BoeingStockData();

            var stockDataPointViewModel = Mapper.Map<IEnumerable<StockDataPointViewModel>>(products);

            return Json(stockDataPointViewModel);
        }

        public JsonResult Get_Categories()
        {
            var products = ProductService.GetCategoriesData();

            var categoryViewModel = Mapper.Map<IEnumerable<CategoryViewModel>>(products);

            return Json(categoryViewModel, JsonRequestBehavior.AllowGet);
        }
    }
}
