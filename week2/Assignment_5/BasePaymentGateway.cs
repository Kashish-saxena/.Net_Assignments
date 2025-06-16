
public abstract class BasePaymentGateway : PaymentMethod, IPaymentGateway
{
    protected BasePaymentGateway(string merchantId) : base(merchantId) { }

    public virtual string CreateOrder(double amount, string customerId)
    {
        Console.WriteLine($"Creating order for {customerId}, amount: ₹{amount}");
        return "orderId_12345";
    }

    public virtual void InitiatePayment(double amount, string customerId, string paymentMethod, string orderId)
    {
        Console.WriteLine($"Initiating payment of ₹{amount} via {paymentMethod} for {customerId} (Order: {orderId})");
    }

    public virtual string Refund(double amount, string transactionId)
    {
        Console.WriteLine($"Refunding ₹{amount} for transaction {transactionId}");
        return "REFUND_SUCCESS";
    }

    public virtual void CapturePayment(string paymentId, double amount)
    {
        Console.WriteLine($"Capturing payment of ₹{amount} with Payment ID: {paymentId}");
    }

    public virtual string TransactionStatus(string transactionId)
    {
        Console.WriteLine($"Checking transaction status for: {transactionId}");
        return "SUCCESS";
    }
}
