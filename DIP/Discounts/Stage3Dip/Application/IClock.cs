namespace DIP.Discounts.Stage3Dip.Application;

// The application needs a current instant, not a particular clock implementation.
public interface IClock
{
    DateTimeOffset UtcNow { get; }
}
