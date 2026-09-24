namespace ISP.Products.After.Restocking;

public class RestockPlanner
{
    public string Plan(IRestockProduct product)
    {
        if (product.Stock >= product.ReorderLevel)
        {
            return $"{product.Sku} {product.Name}: no restock needed.";
        }

        return $"{product.Sku} {product.Name}: order {product.ReorderLevel - product.Stock}.";
    }
}
