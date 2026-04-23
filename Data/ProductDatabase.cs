namespace ErpCli.Data
{
    public partial class Database
    {
        public List<Product> ProductList = new List<Product>();

        public Product GetProduct(int id)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                Product product = ProductList[i];
                if (product.Id == id)
                    return product;
            }
        }
        public List<Product> GetProducts()
        {
            return ProductList;
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
        public void DeleteProduct(int Id)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                Product product = ProductList[i];
                if (product.Id == Id)
                    ProductList.Remove(i);
            }
        }
    }
}