using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class DetailProductViewModel : ViewModel<DetailProduct>
    {
        private int? targetSales;

        public int ProductID { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = " The Name should be a maximum of 50 characters")]
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier")]
        public int? SupplierID { get; set; }

        [Display(Name = "Category")]
        public int? CategoryID { get; set; }

        public Category Category { get; set; }

        public Country Country { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Price")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "In Stock")]
        public uint? UnitsInStock { get; set; }

        [Display(Name = "Units on order")]
        public uint? UnitsOnOrder { get; set; }

        public byte? CustomerRating { get; set; }

        public uint? ReorderLevel { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public bool Discontinued { get; set; }

        public int? TargetSales
        {
            get
            {
                return targetSales;
            }
            set
            {
                targetSales = value;
                TotalSales = value * 100;
            }
        }
        public int? TotalSales { get; set; }
    }
}