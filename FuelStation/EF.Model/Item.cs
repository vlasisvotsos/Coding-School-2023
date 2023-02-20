

using EF.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace EF.Model
{
    public class Item
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        [Range(0,9999999999)]
        public decimal Price { get; set; }
        [Range(0, 9999999999)]
        public decimal Cost { get; set; }
        public TransactionLine TransactionLine { get; set; }

        public Item()
        {
            
        }

    }
}
