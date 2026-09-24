using DIP.Orders.After.Application;

namespace DIP.Orders.Demo;

// A test double records the notification instead of delivering it.
public class RecordingOrderNotifier : IOrderNotifier
{
    public Order? LastNotifiedOrder { get; private set; }

    public void NotifyOrderPlaced(Order order)
    {
        LastNotifiedOrder = order;
    }
}
