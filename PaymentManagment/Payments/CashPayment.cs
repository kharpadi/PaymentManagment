using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Payments
{
    public class CashPayment : IPaymentService
    {
        public string Pay(string message)
        {
            return message + " payment made by Cash.";
        }
    }
}
