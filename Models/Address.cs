namespace TelerikMvcTraining.Models
{
    public class Address : Entity
    {
        public string City { get; set; }

        public string State { get; set; }

        public Country Country { get; set; }
    }
}