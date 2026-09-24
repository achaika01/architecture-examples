using DIP.Discounts.Stage3Dip.Application;

namespace DIP.Discounts.Stage3Dip.Infrastructure;

public class ConsoleReceiptPrinter : IReceiptPrinter
{
    public void Print(Receipt receipt)
    {
        Console.WriteLine(FormattableString.Invariant(
            $"Subtotal: {receipt.Subtotal:F2} | Rate: {receipt.DiscountRate:P0} | Discount: {receipt.Discount:F2} | Total: {receipt.Total:F2}"));
    }
}
