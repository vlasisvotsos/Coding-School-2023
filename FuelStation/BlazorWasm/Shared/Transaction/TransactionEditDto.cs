using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF.Model.Transaction;

namespace BlazorWasm.Shared.Transaction
{
    public class TransactionEditDto
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public TransactionEditDto() 
        {
            Date = DateTime.Now;
        }

    }
}
