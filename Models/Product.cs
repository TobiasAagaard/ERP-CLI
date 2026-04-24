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
        public double? ProfitPercent => ((Price - Cost) / Price) * 100;
        public string? Location { get; set; }
        public double StockQuantity { get; set; }
    }
    public enum Unit
    {
        Pieces, Hours, Meters
    }
}