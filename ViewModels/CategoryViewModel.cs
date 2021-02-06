using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public class CategoryViewModel : ViewModel<Category>
    {
        public int CategoryIDVm { get; set; }

        public string CategoryNameVm { get; set; }

        public string DescriptionVm { get; set; }

        public byte[] PictureVm { get; set; }
    }
}