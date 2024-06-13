 //Need to develop a payment processing system that can integrate with multiple payment gateways,
 //such as PayPal and Stripe. The system should be able to process payments,
 //check transaction statuses, and refund payments without the client code
 //being aware of the specific payment gateway being used.

using PaymentProcessingGateway;

 class PaymentClient
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentClient(IProcessingGatewayFactory factory)
    {
        _paymentProcessor = factory.CreatePaymentProcessor();
    }

    public void ExecutePayment(decimal amount)
    {
        _paymentProcessor.PaymentProcessing(amount);
        var transactionStatus = _paymentProcessor.CheckTStatus("12345");
        Console.WriteLine($"Transaction Status: {transactionStatus}");
        var refundResult = _paymentProcessor.RefundPayment("12345");
        Console.WriteLine($"Refund Successful: {refundResult}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        IProcessingGatewayFactory payPalFactory = new PayPalFactory();
        PaymentClient paypalClient = new PaymentClient(payPalFactory);
        paypalClient.ExecutePayment(100.00m);

        Console.ReadLine();

        IProcessingGatewayFactory stripeFactory = new StripeFactory();
        PaymentClient stripeClient = new PaymentClient(stripeFactory);
        stripeClient.ExecutePayment(200.00m);

        Console.ReadLine();

        IProcessingGatewayFactory payPalFact = new PayPalFactory();
        IPaymentProcessor paymentProcessor = payPalFact.CreatePaymentProcessor();
        paymentProcessor.RefundPayment("123");

    }
}
