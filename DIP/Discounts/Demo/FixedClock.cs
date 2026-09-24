using DIP.Discounts.Stage3Dip.Application;

namespace DIP.Discounts.Demo;

public class FixedClock : IClock
{
    public FixedClock(DateTimeOffset utcNow)
    {
        UtcNow = utcNow;
    }

    public DateTimeOffset UtcNow { get; }
}
