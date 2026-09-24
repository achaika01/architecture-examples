namespace ISP.Products.Before;

public record Product(string Name, decimal Price, string Sku, int Stock, int ReorderLevel) : IProduct;
