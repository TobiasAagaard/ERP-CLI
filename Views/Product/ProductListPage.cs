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

            listPage.AddKey(ConsoleKey.F3, createNewProduct);
            Console.WriteLine("Tryk F3 for at oprette et nyt produkt");

            listPage.AddKey(ConsoleKey.F5, RemoveProduct);
            Console.WriteLine("Tryk F5 for at slette et produkt");

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
        void createNewProduct(Product _)
        {
            Product new_product = new();
            Screen.Display(new ProductEditor(new_product));
        }
        void RemoveProduct(Product product) 
        {
            Database.Instance.DeleteProduct(product);
            Screen.Clear();
            Draw();
        }
    }
}