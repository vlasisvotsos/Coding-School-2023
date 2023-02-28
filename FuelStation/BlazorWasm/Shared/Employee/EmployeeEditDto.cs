using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF.Model.Employee;

namespace BlazorWasm.Shared.Employee
{
    public class EmployeeEditDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HiretDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public EmployeeEditDto() 
        {
            HiretDateStart = DateTime.Now;
        }
    }
}
