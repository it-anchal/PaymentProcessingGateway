using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingGateway;
public class StripeFactory : IProcessingGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new StripeProcessing();
    }
}
