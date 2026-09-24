namespace ISP.Products.Before;

public class LabelPrinter
{
    public void Print(IProduct product)
    {
        Console.WriteLine(FormattableString.Invariant($"{product.Name}: {product.Price:F2}"));
    }
}
