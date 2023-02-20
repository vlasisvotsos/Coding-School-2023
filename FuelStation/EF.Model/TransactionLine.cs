namespace EF.Model
{
    public class TransactionLine
    {
        public int ID { get; set; }
        public int TransactionID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
        public Transaction Transaction { get; set; }
        public Item Item { get; set; }

        public TransactionLine()
        {
            
        }
    }
}
