using DIP.Discounts.Stage2Classes.Infrastructure;

namespace DIP.Discounts.Stage2Classes.Application;

public class DiscountPolicy
{
    private readonly SystemClock clock = new();

    public Receipt Calculate(decimal subtotal, bool isVip)
    {
        if (subtotal <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(subtotal), "Subtotal must be positive.");
        }

        var now = clock.UtcNow;
        var discountRate = 0m;

        if (isVip)
        {
            discountRate += 0.10m;
        }

        if (subtotal >= 200m)
        {
            discountRate += 0.05m;
        }

        if (now >= new DateTimeOffset(2026, 9, 25, 0, 0, 0, TimeSpan.Zero)
            && now < new DateTimeOffset(2026, 9, 28, 0, 0, 0, TimeSpan.Zero))
        {
            discountRate += 0.10m;
        }

        discountRate = Math.Min(discountRate, 0.20m);
        var discount = Math.Round(subtotal * discountRate, 2, MidpointRounding.AwayFromZero);
        return new Receipt(subtotal, discountRate, discount, subtotal - discount);
    }
}
