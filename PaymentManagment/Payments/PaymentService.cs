using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Payments
{
    public class PaymentService
    {
        private readonly IPaymentService _paymentService;

        public PaymentService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public string Payment(string message)
        {
            return _paymentService.Pay(message);
        }
    }
}
