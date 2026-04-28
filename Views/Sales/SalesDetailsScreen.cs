using TECHCOOL.UI;
using ErpCli.Models;
using ErpCli.Data;

namespace ErpCli.Views
{
    public class SalesDetailsScreen : Screen
    {
        public override string Title { get; set; } = "Salgsordredetaljer";
        SalesOrderHeader salesOrderHeader = new();

        public SalesDetailsScreen(SalesOrderHeader salesOrderHeader)
        {
            Title = "Detaljer for " + salesOrderHeader.OrderNumber;
            this.salesOrderHeader = salesOrderHeader;
        }

        protected override void Draw()
        {
            ExitOnEscape();

            Console.WriteLine($"Ordrenummer: {salesOrderHeader.OrderNumber}");
            Console.WriteLine($"Dato: {salesOrderHeader.OrderCreatedAt}");
            Console.WriteLine($"Kundenummer: {salesOrderHeader.CustomerId}");
            //Console.WriteLine($"Navn: {salesOrderHeader.}");

            Console.WriteLine("Tryk F2 for at redigere");
            AddKey(ConsoleKey.F2, () => {
                throw new NotImplementedException();
            });
        }
    }
}