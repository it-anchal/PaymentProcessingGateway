using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingGateway;
public class PayPalProcessing : IPaymentProcessor
{
    public void PaymentProcessing(decimal amount)
    {
        Console.WriteLine($"paypal Payment processing {amount}");
    }

    public string CheckTStatus(string transactionId)
    {
        Console.WriteLine($"Checking transaction of paypal for id {transactionId}");
        return "Completed";
    }

    public bool RefundPayment(string transactionId)
    {
        Console.WriteLine($"Refund paypal  payment for {transactionId} ");
        return true;
    }

    
}
