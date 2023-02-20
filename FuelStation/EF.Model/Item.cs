

using EF.Model.Enums;

namespace EF.Model
{
    public class Item
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public Item()
        {
            
        }

    }
}
