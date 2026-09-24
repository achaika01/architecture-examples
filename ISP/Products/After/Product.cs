using ISP.Products.After.Labels;
using ISP.Products.After.Restocking;

namespace ISP.Products.After;

// One implementation supplies both client views.
public record Product(string Name, decimal Price, string Sku, int Stock, int ReorderLevel)
    : ILabelProduct, IRestockProduct;
