using TECHCOOL.UI;
using ErpCli.Models;
using ErpCli.Data;

namespace ErpCli.Views
{
    public class ProductListPage : Screen
    {
        public override string Title { get; set; } = "Produktliste";

        protected override void Draw()
        {
            ExitOnEscape();

            ListPage<Product> listPage = new();

            listPage.AddColumn("Varenummer", nameof(Product.ItemNumber));
            listPage.AddColumn("Navn", nameof(Product.Name));
            listPage.AddColumn("Lagerantal", nameof(Product.StockQuantity));
            listPage.AddColumn("Indkøbspris", nameof(Product.Cost));
            listPage.AddColumn("Salgspris", nameof(Product.Price));
            listPage.AddColumn("Avance i procent", nameof(Product.ProfitPercent));


            var products = Database.Instance.GetProducts();
            foreach (Product model in products)
            {
                listPage.Add(model);
            }

            var product = listPage.Select();
            if (product != null) 
            {
                Display(new ProductDetails(product));
            }
            else
            {
                Quit();
            }
        }
    }
}