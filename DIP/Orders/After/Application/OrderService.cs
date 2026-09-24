namespace DIP.Orders.After.Application;

public class OrderService
{
    private readonly IOrderNotifier notifier;

    public OrderService(IOrderNotifier notifier)
    {
        this.notifier = notifier;
    }

    public void PlaceOrder(Order order)
    {
        if (order.Total <= 0)
        {
            throw new ArgumentException("Order total must be positive.", nameof(order));
        }

        notifier.NotifyOrderPlaced(order);
    }
}
