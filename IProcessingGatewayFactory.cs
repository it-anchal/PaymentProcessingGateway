using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingGateway;
 interface IProcessingGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
}
