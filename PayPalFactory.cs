using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingGateway;
public class PayPalFactory : IProcessingGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new PayPalProcessing();
    }
}
