using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16 {
    public class Customer  {

        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid CustomerID { get; set; }
        public string Phone { get; set; }
        public string TIN { get; set; }

        public string FullName {
            get { return String.Format("{0} {1}", Name, Surname); }
        }

        public Customer() {
            CustomerID = Guid.NewGuid();
        }    
        
    }
}
