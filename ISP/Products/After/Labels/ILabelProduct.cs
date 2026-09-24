namespace ISP.Products.After.Labels;

// The label client defines the view it needs.
public interface ILabelProduct
{
    string Name { get; }
    decimal Price { get; }
}
