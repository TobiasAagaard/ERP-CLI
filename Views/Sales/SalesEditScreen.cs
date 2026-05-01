using TECHCOOL.UI;
using ErpCli.Models;
using ErpCli.Data;
using ErpCli.Utils;

namespace ErpCli.Views
{
    public class SalesEditScreen : Screen
    {
        public override string Title { get; set; } = "Salgsordre";
        SalesOrderHeader salesOrderHeader = new();

        public SalesEditScreen(SalesOrderHeader salesOrderHeader)
        {
            if (salesOrderHeader.OrderNumber > 0)
            {
                Title = "Redigerer for " + salesOrderHeader.OrderNumber;
            }
            else
            {
                Title = "Opret ny salgsordre";
            }
            this.salesOrderHeader = salesOrderHeader;
        }

        protected override void Draw()
        {
            ExitOnEscape();

            salesOrderHeader.customer = Database.Instance.FormSearchSalesOrderHeader("Phone");
            Console.WriteLine($"Navn: {salesOrderHeader.FullName}");
            Form<SalesOrderHeader> form = new();
        }
    }
}