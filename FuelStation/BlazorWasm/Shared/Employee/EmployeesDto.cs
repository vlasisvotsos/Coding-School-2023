using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF.Model.Employee;

namespace BlazorWasm.Shared.Employee
{
    public class EmployeesDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HiretDateStart { get; set; }
        public DateTime HireDateEnd { get; set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public EmployeesDto() { }
    }
}
