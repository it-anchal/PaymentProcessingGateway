using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingGateway;
public interface IPaymentProcessor
{
    void PaymentProcessing(decimal amount);
    string CheckTStatus(string transactionId);
    bool RefundPayment(string transactionId);
}
