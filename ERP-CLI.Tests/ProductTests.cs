using ErpCli.Models;

namespace ERP_CLI.Tests;

public class ProductTests
{
    [Fact]
    public void ProfitPercent_WhenPriceIsDoubleCost_Returns100()
    {
        Product product = new Product
        {
            Price = 100,
            Cost = 50,
        };

        var result = product.ProfitPercent;

        Assert.Equal(100, result);
    }
}
