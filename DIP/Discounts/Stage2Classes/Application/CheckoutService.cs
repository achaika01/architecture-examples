using DIP.Discounts.Stage2Classes.Infrastructure;

namespace DIP.Discounts.Stage2Classes.Application;

public class CheckoutService
{
    // Responsibilities are separated, but concrete dependencies are still chosen here.
    private readonly DiscountPolicy discountPolicy = new();
    private readonly ConsoleReceiptPrinter receiptPrinter = new();

    public Receipt Complete(decimal subtotal, bool isVip)
    {
        var receipt = discountPolicy.Calculate(subtotal, isVip);
        receiptPrinter.Print(receipt);
        return receipt;
    }
}
