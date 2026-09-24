namespace ISP.Products.Before;

public class RestockPlanner
{
    public string Plan(IProduct product)
    {
        if (product.Stock >= product.ReorderLevel)
        {
            return $"{product.Sku} {product.Name}: no restock needed.";
        }

        return $"{product.Sku} {product.Name}: order {product.ReorderLevel - product.Stock}.";
    }
}
