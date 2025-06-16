
public class PayPalPayment : BasePaymentGateway
{
    private string paypalEmail;

    public PayPalPayment(string merchantId, string paypalEmail) : base(merchantId)
    {
        this.paypalEmail = paypalEmail;
    }

    public override void InitiatePayment(double amount, string customerId, string paymentMethod, string orderId)
    {
        Console.WriteLine($"PayPal => Processing ₹{amount} via {paymentMethod} for {customerId} Order: {orderId} to {paypalEmail}");
    }

    public override string Refund(double amount, string transactionId)
    {
        Console.WriteLine($"PayPal => Refunding ₹{amount} for transaction {transactionId} to {paypalEmail}");
        return "PAYPAL_REFUND_SUCCESS";
    }

    public override void ShowProviderInfo()
    {
        Console.WriteLine($"PayPal => Merchant: {MerchantId}, Email: {paypalEmail}");
    }
}
