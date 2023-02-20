namespace EF.Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public Customer()
        {
            
        }
    }
}
