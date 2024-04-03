namespace Store_mvc.Models
{
    public class Product
    {
        public int  Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateOnly  ExpirationDate { get; set; }
    }
}