public interface IPaymentGateway
{
    string CreateOrder(double amount, string customerId);
    void InitiatePayment(double amount, string customerId, string paymentMethod, string orderId);
    void CapturePayment(string paymentId, double amount);
    string TransactionStatus(string transactionId);
    string Refund(double amount, string transactionId);
}

public abstract class PaymentMethod
{
    protected string MerchantId;

    public PaymentMethod(string merchantId)
    {
        MerchantId = merchantId;
        Console.WriteLine($"Payment for merchant {MerchantId} initialized.");
    }

    public abstract void ShowProviderInfo();
}

