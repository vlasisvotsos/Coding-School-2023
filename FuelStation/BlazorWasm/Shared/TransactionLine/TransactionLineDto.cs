using EF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Shared.TransactionLine
{
    public class TransactionLineDto
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
        public Item Item { get; set; }

        public TransactionLineDto() 
        {
            NetValue = ItemPrice * Quantity;
            if(Item.ItemType==Item.ItemTypeEnum.Fuel && NetValue>20)
            {
                DiscountPercent = (decimal)0.1;
            }
            DiscountValue = NetValue * DiscountPercent;
            TotalValue = NetValue - DiscountValue;
        }

    }
}
