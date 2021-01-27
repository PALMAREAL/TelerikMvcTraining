﻿using System.Web.Mvc;
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
        public IProductRepository ProductRepository { get; set; }

        public ProductController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

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
            return Json(ProductRepository.GetAllProducts().ToDataSourceResult(request));
        }

        public ActionResult DetailProducts_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(ProductRepository.GetAllDetailsProducts().ToDataSourceResult(request));
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
    }
}
