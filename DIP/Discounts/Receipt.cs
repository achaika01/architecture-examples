namespace DIP.Discounts;

// Shared result data only; each stage implements its own behavior.
public record Receipt(decimal Subtotal, decimal DiscountRate, decimal Discount, decimal Total);
