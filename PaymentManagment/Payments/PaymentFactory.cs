using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Payments
{
    public class PaymentFactory
    {
        public IPaymentService GetInstance(string className)
        {
            var newClass = Assembly.GetAssembly(typeof(IPaymentService)).CreateInstance("PaymentManagment.Payments."+className);
            return (IPaymentService)newClass;
        }
    }
}
