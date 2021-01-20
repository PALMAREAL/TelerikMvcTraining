namespace TelerikMvcTraining.Models
{
    public class Country : Entity
    {
        public byte CountryID { get; set; }

        public string CountryNameShort { get; set; }

        public string CountryNameLong { get; set; }
    }
}