namespace EF.Model
{
    public class Transaction
    {
        public enum PaymentMethodEnum
        {
            CreditCard,
            Cash
        }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<TransactionLine> TransactionLineList { get; set; }
        public List<Item> ItemList { get; set; }

        public Transaction()
        {
            Date = DateTime.Now;
        }
        public Transaction(int id)
        {
            ID = id;
            Date= DateTime.Now;
        }
    }
}
