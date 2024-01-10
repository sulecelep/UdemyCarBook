namespace UdemyCarBook.Domain.Entities
{
    public class CarPricing
    {
        public int CarPricingID { get; set; }
        public int CarID { get; set; }
        public int PricingID { get; set; }
        public decimal Amount { get; set; }
        public Car Car { get; set; }
        public Pricing Pricing { get; set; }
    }
}
