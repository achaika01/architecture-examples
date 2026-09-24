namespace DIP.Orders.After.Application;

// The application defines what it needs, without mentioning email or SMTP.
public interface IOrderNotifier
{
    void NotifyOrderPlaced(Order order);
}
