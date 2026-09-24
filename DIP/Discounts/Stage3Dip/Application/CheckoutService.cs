namespace DIP.Discounts.Stage3Dip.Application;

public class CheckoutService
{
    private readonly IDiscountPolicy discountPolicy;
    private readonly IReceiptPrinter receiptPrinter;

    public CheckoutService(IDiscountPolicy discountPolicy, IReceiptPrinter receiptPrinter)
    {
        this.discountPolicy = discountPolicy;
        this.receiptPrinter = receiptPrinter;
    }

    public Receipt Complete(decimal subtotal, bool isVip)
    {
        var receipt = discountPolicy.Calculate(subtotal, isVip);
        receiptPrinter.Print(receipt);
        return receipt;
    }
}
