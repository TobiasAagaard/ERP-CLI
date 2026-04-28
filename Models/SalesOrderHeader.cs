namespace ErpCli.Models
{
    public class SalesOrderHeader
    {
        public int OrderNumber { get; set;}
        public DateTime OrderCreatedAt { get; set; }
        public DateTime OrderCompletedAt { get; set;}
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderLine> OrderLineList = new List<OrderLine>();
        public double? OrderTotal()
        {
            double? result = 0;
            foreach(OrderLine orderLine in OrderLineList)
            {
                result += orderLine.Product?.Price;
            }
            return result;
        }
        public enum OrderStatus
        {
            Ingen,
            Oprettet,
            Bekræftet,
            Pakket,
            Færdig
        }
    }
}