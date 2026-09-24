namespace ISP.Products.After.Labels;

public class LabelPrinter
{
    public void Print(ILabelProduct product)
    {
        Console.WriteLine(FormattableString.Invariant($"{product.Name}: {product.Price:F2}"));
    }
}
