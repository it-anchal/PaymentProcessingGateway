using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingGateway;
public class StripeProcessing : IPaymentProcessor
{
    public void PaymentProcessing(decimal amount)
    {
        Console.WriteLine($"stripe Payment processing {amount}");
    }

    public string CheckTStatus(string transactionId)
    {
        Console.WriteLine($"Checking transaction of stripe for id {transactionId}");
        return "Completed";
    }

    public bool RefundPayment(string transactionId)
    {
        Console.WriteLine($"Refund stripe  payment for {transactionId} ");
        return true;
    }
}
