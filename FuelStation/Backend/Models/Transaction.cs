using Backend.Models.Enums;

namespace Backend.Models
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public Transaction()
        {
            ID = Guid.NewGuid();
        }
    }
}
