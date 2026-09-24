namespace DIP.Discounts.Stage2Classes.Infrastructure;

public class SystemClock
{
    public DateTimeOffset UtcNow
    {
        get
        {
            return DateTimeOffset.UtcNow;
        }
    }
}
