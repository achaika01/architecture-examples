namespace DIP.Discounts.Stage3Dip.Application;

public interface IDiscountPolicy
{
    Receipt Calculate(decimal subtotal, bool isVip);
}
