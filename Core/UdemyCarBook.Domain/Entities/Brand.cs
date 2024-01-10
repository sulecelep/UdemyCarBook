namespace UdemyCarBook.Domain.Entities
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
