using AutoMapper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelerikMvcTraining.Services;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Controllers
{
    public class DropdownListController : BaseController
    {
        public IProductService ProductService { get; set; }

        public DropdownListController(IProductService productService, IMapper mapper) : base(mapper)
        {
            ProductService = productService;
        }

        public ActionResult BasicDropDownList()
        {
            return View();
        }

        public ActionResult ProDropDownList()
        {
            return View();
        }

        public ActionResult Detail_Products_Read()
        {
            var products = ProductService.GetAllDetailsProducts();

            var detailProductViewModel = Mapper.Map<IEnumerable<DetailProductViewModel>>(products);

            return Json(detailProductViewModel, JsonRequestBehavior.AllowGet);
        }        
    }
}
