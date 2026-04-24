namespace ErpCli.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ItemNumber { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public double? Cost { get; set; }
        public double? ProfitPercent => (Price.HasValue && Cost.HasValue && Cost.Value != 0) ? ((Price.Value - Cost.Value) / Cost.Value) * 100 : (double?)null;
        public string? Location { get; set; }
        public double StockQuantity { get; set; }
    }
    public enum Unit
    {
        Pieces, Hours, Meters
    }
}