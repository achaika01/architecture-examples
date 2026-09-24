namespace ISP.Products.After.Restocking;

// Name is also used by labels. Client views may overlap.
public interface IRestockProduct
{
    string Name { get; }
    string Sku { get; }
    int Stock { get; }
    int ReorderLevel { get; }
}
