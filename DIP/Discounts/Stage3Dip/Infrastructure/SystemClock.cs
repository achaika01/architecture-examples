using DIP.Discounts.Stage3Dip.Application;

namespace DIP.Discounts.Stage3Dip.Infrastructure;

public class SystemClock : IClock
{
    public DateTimeOffset UtcNow
    {
        get
        {
            return DateTimeOffset.UtcNow;
        }
    }
}
