using ErpCli.Models;

namespace ErpCli.Data
{
    public partial class Database
    {
        List<SalesOrderHeader> SalesOrderHeaderList = new List<SalesOrderHeader>()
        {
            new SalesOrderHeader { OrderNumber = 1, OrderCreatedAt = new DateTime(2025, 12, 05), OrderCompletedAt = new DateTime(2025, 12, 06), CustomerId = 5, Status = SalesOrderHeader.OrderStatus.Oprettet}
        };
        public SalesOrderHeader GetSalesOrderHeader(int id)
        {
            for (int i = 0; i < SalesOrderHeaderList.Count; i++)
            {
                SalesOrderHeader SalesOrderHeader = SalesOrderHeaderList[i];
                if (SalesOrderHeader.OrderNumber == id)
                    return SalesOrderHeader;
            }
            return null;
        }
        public List<SalesOrderHeader> GetSalesOrderHeaders()
        {
            List<SalesOrderHeader> SalesOrderHeaderCopy = new();
            SalesOrderHeaderCopy.AddRange(SalesOrderHeaderList);
            return SalesOrderHeaderCopy;
        }
        public void AddSalesOrderHeader(SalesOrderHeader SalesOrderHeader)
        {
            SalesOrderHeaderList.Add(SalesOrderHeader);
        }
        public void UpdateSalesOrderHeader(SalesOrderHeader editSalesOrderHeader)
        {
            for (int i = 0; i < SalesOrderHeaderList.Count; i++)
            {
                SalesOrderHeader SalesOrderHeader = SalesOrderHeaderList[i];
                if (SalesOrderHeader.OrderNumber == editSalesOrderHeader.OrderNumber)
                    SalesOrderHeaderList[i] = editSalesOrderHeader;
            }
        }
        public void DeleteSalesOrderHeader(int id)
        {
            for (int i = 0; i < SalesOrderHeaderList.Count; i++)
            {
                SalesOrderHeader salesOrderHeader = SalesOrderHeaderList[i];
                if (salesOrderHeader.OrderNumber == id)
                {
                    SalesOrderHeaderList.RemoveAt(i);
                    break;
                }
            }
        }
    }
    
}