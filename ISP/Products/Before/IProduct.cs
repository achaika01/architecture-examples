namespace ISP.Products.Before;

// A contract describing everything the product supplies.
public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
    string Sku { get; }
    int Stock { get; }
    int ReorderLevel { get; }
}
