using Microsoft.EntityFrameworkCore;
using PaymentManagment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Context
{
    public class AppDbContext: DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NART-LAPTOP;Initial Catalog=paymentAppDb;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False");
        }

        public DbSet<Payment> Payments { get; set; }
    }
}
