namespace E_CommerceApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Images { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }
        public int Reviews { get; set; }
        public int StockCount { get; set; }
        public Dictionary<string, object> Specs { get; set; }
        public bool Featured { get; set; }
    }
}
