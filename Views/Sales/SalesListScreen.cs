using TECHCOOL.UI;
using ErpCli.Models;
using ErpCli.Data;

namespace ErpCli.Views
{
    public class SalesListScreen : Screen
    {
        public override string Title { get; set; } = "Salgsliste";

        protected override void Draw()
        {
            ExitOnEscape();

            ListPage<SalesOrderHeader> listPage = new();

            listPage.AddColumn("Salgsordrenummer", nameof(SalesOrderHeader.OrderNumber));
            listPage.AddColumn("Dato", nameof(SalesOrderHeader.OrderCreatedAt));
            listPage.AddColumn("Kundenummer", nameof(SalesOrderHeader.CustomerId));
            //listPage.AddColumn("Navn", nameof(SalesOrderHeader.));
            listPage.AddColumn("Beløb", nameof(SalesOrderHeader.OrderTotal));


            List<SalesOrderHeader> salesOrderHeaders = Database.Instance.GetSalesOrderHeaders();
            foreach (SalesOrderHeader model in salesOrderHeaders)
            {
                listPage.Add(model);
            }

            SalesOrderHeader salesOrderHeader = listPage.Select();
            if (salesOrderHeader != null) 
            {
                Display(new SalesDetailsScreen(salesOrderHeader));
            }
            else
            {
                Quit();
            }
        }
    }
}