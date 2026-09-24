namespace DIP.Discounts.Stage2Classes.Infrastructure;

public class ConsoleReceiptPrinter
{
    public void Print(Receipt receipt)
    {
        Console.WriteLine(FormattableString.Invariant(
            $"Subtotal: {receipt.Subtotal:F2} | Rate: {receipt.DiscountRate:P0} | Discount: {receipt.Discount:F2} | Total: {receipt.Total:F2}"));
    }
}
