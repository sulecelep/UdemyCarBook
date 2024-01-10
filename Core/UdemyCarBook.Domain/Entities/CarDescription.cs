namespace UdemyCarBook.Domain.Entities
{
    public class CarDescription
    {
        public int CarDescriptionID { get; set; }
        public string Details { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }

    }
}
