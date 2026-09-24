using DIP.Orders.After.Application;

namespace DIP.Orders.After.Infrastructure;

// Infrastructure depends on the contract defined by the application.
public class SmtpEmailNotifier : IOrderNotifier
{
    public void NotifyOrderPlaced(Order order)
    {
        var subject = "Order confirmation";
        var body = $"Order #{order.Id} has been placed.";

        // Simulated SMTP: no network connection or credentials needed.
        Console.WriteLine($"[Email] To: {order.CustomerEmail} | {subject} | {body}");
    }
}
