using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagment.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string DatabaseName { get; set; }
    }
}
