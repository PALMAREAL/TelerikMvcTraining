using System.Collections.Generic;

namespace TelerikMvcTraining.Models
{
    public class Category : Entity
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public int? Picture { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   CategoryID == category.CategoryID &&
                   CategoryName == category.CategoryName &&
                   Description == category.Description &&
                   Picture == category.Picture;
        }

        public override int GetHashCode()
        {
            int hashCode = 1604116264;
            hashCode = hashCode * -1521134295 + CategoryID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CategoryName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + Picture.GetHashCode();
            return hashCode;
        }
    }
}