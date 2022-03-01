using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer : BaseEntity
    {
        public string CusomerName { get; set; }
        public string PurchasesProduct { get; set; }
        public string PaymentType { get; set; }
    }
}
