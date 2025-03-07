using PaymentManagment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Repository
{
    public interface IPaymentRepository
    {
        public Task<List<Payment>> GetAllPaymentsAsync();
    }
}
