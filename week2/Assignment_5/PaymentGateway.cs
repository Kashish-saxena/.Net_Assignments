
public class PaymentGateway
{
    public void MakePayment(IPaymentGateway gateway, double amount, string customerId, string paymentMethod)
    {
        string orderId = gateway.CreateOrder(amount, customerId);
        gateway.InitiatePayment(amount, customerId, paymentMethod, orderId);
        gateway.CapturePayment("orderId_12345", amount);
    }

    public void MakeRefund(IPaymentGateway gateway, double amount, string transactionId)
    {
        string result = gateway.Refund(amount, transactionId);
        Console.WriteLine($"Refund Status: {result}");
    }

    public void CheckStatus(IPaymentGateway gateway, string transactionId)
    {
        string status = gateway.TransactionStatus(transactionId);
        Console.WriteLine($"Transaction Status: {status}");
    }
}
