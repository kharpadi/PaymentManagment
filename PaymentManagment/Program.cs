using Microsoft.Extensions.DependencyInjection;
using PaymentManagment.Context;
using PaymentManagment.Payments;
using PaymentManagment.Repository;
using System;
using System.Windows.Forms;

namespace PaymentManagment
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Form1>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(); // EF Core DbContext ekleniyor
            services.AddScoped<IPaymentRepository, PaymentRepository>(); // Generic Repository ekleniyor
            services.AddScoped<Form1>(); // Form1 DI container'a ekleniyor
        }
    }
}
