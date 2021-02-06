using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class ProductViewModel : ViewModel<Product>
    {
        public int ProductIDVm { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = " The Name should be a maximum of 50 characters")]
        [Display(Name = "Name")]
        public string ProductNameVm { get; set; }

        [Display(Name = "Supplier")]
        public int? SupplierIDVm { get; set; }

        [Display(Name = "Category")]
        public int? CategoryIDVm { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string QuantityPerUnitVm { get; set; }

        [Display(Name = "Price")]
        public decimal? UnitPriceVm { get; set; }

        [Display(Name = "In Stock")]
        public uint? UnitsInStockVm { get; set; }

        [Display(Name = "Units on order")]
        public uint? UnitsOnOrderVm { get; set; }

        public uint? ReorderLevelVm { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public bool DiscontinuedVm { get; set; }
    }
}