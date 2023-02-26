using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF.Model.Item;

namespace BlazorWasm.Shared.Items
{
    public class ItemEditDto
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public ItemEditDto() { }
    }
}
