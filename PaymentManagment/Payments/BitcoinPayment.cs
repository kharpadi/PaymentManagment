using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Payments
{
    public class BitcoinPayment : IPaymentService
    {
        public string Pay(string message)
        {
            return message + " payment made with Bitcoin.";
        }
    }
}
