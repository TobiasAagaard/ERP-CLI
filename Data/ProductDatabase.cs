using ErpCli.Models;

namespace ErpCli.Data
{
    public partial class Database
    {
        List<Product> ProductList = new List<Product>()
        {
            new Product { Id = 1, ItemNumber = "1", Name = "test1", Description = "test1", Price = 10d, Cost = 1d, Location = "test1", StockQuantity = 10d},
            new Product { Id = 2, ItemNumber = "2", Name = "test2", Description = "test2", Price = 20d, Cost = 2d, Location = "test2", StockQuantity = 20d}
        };

        public Product GetProduct(int id)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                Product product = ProductList[i];
                if (product.Id == id)
                    return product;
            }
            return null;
        }
        public List<Product> GetProducts()
        {
            List<Product> productCopy = new();
            productCopy.AddRange(ProductList);
            return productCopy;
        }
        public void AddProduct(Product product)
        {
            ProductList.Add(product);
        }
        public void UpdateProduct(Product editProduct)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                Product product = ProductList[i];
                if (product.Id == editProduct.Id)
                    ProductList[i] = editProduct;
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                Product product = ProductList[i];
                if (product.Id == id)
                {
                    ProductList.RemoveAt(i);
                    break;
                }

            }
        }
    }
}