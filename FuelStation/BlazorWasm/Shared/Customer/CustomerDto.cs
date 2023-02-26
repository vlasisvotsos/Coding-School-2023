using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Shared.Customer
{
    public class CustomerDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
        public CustomerDto() { }
    }
}
