using Microsoft.EntityFrameworkCore;
using PaymentManagment.Context;
using PaymentManagment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetAllPaymentsAsync()
        {
            var payments = await _context.Payments.ToListAsync();
            return payments;
        }
    }
}
