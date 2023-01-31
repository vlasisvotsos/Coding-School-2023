using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16 {
    public class Employee  {
        public enum EmployeeTypeEnum {
            Manager,
            Staff
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Guid EmployeeID { get; set; }
        public double SalaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        public Employee() {
            EmployeeID = Guid.NewGuid();

        }
    }
}
