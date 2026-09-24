using DIP.Orders.Before.Infrastructure;

namespace DIP.Orders.Before.Application;

public class OrderService
{
    // The business service chooses and constructs its delivery mechanism.
    private readonly SmtpEmailSender emailSender = new();

    public void PlaceOrder(Order order)
    {
        if (order.Total <= 0)
        {
            throw new ArgumentException("Order total must be positive.", nameof(order));
        }

        // The business service also knows how to compose an email.
        emailSender.Send(
            order.CustomerEmail,
            "Order confirmation",
            $"Order #{order.Id} has been placed.");
    }
}
