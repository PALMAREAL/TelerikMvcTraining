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

        public int PictureVm { get; set; }

        public override bool Equals(object obj)
        {
            return obj is CategoryViewModel model &&
                   CategoryIDVm == model.CategoryIDVm &&
                   CategoryNameVm == model.CategoryNameVm &&
                   DescriptionVm == model.DescriptionVm &&
                   PictureVm == model.PictureVm;
        }

        public override int GetHashCode()
        {
            int hashCode = 193832932;
            hashCode = hashCode * -1521134295 + CategoryIDVm.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CategoryNameVm);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionVm);
            hashCode = hashCode * -1521134295 + PictureVm.GetHashCode();
            return hashCode;
        }
    }
}