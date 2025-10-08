namespace ABCRetailers.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> FeaturedProducts { get; set; } = new List<Product>();
        public int ProductCount { get; set; }
        public int CustomerCount { get; set; }
        public int OrderCount { get; set; }
        public string SearchTerm { get; set; } = string.Empty;
    }
}
