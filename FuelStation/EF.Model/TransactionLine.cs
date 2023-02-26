using System.ComponentModel.DataAnnotations;

namespace EF.Model
{
    public class TransactionLine
    {
        public int ID { get; set; }
        public int TransactionID { get; set; }
        public int ItemID { get; set; }
        [Range(0,100000)]
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

        public TransactionLine(int id)
        {
            ID = id;
        }
    }
}
