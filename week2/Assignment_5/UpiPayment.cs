
public class UpiPayment : BasePaymentGateway
{
    private string upiId;

    public UpiPayment(string merchantId, string upiId) : base(merchantId)
    {
        this.upiId = upiId;
    }

    public override void InitiatePayment(double amount, string customerId, string paymentMethod, string orderId)
    {
        Console.WriteLine($"UPI => Processed ₹{amount} via {paymentMethod} for {customerId} Order: {orderId} to {upiId}");
    }

    public override void ShowProviderInfo()
    {
        Console.WriteLine($"UPI => Merchant: {MerchantId}, UPI ID: {upiId}");
    }
}
