
public class CreditCardPayment : BasePaymentGateway
{
    private string cardNumber;

    public CreditCardPayment(string merchantId, string cardNumber) : base(merchantId)
    {
        this.cardNumber = cardNumber;
    }

    public override void InitiatePayment(double amount, string customerId, string paymentMethod, string orderId)
    {
        Console.WriteLine($"CreditCard => Charging ₹{amount} to card ending in {cardNumber} for {customerId} Order: {orderId}");
    }

    public override void ShowProviderInfo()
    {
        Console.WriteLine($"CreditCard => Merchant: {MerchantId}, Card: {cardNumber}");
    }
}