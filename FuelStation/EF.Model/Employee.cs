using System.ComponentModel.DataAnnotations;

namespace EF.Model
{
    public class Employee
    {
        public enum EmployeeTypeEnum
        {
            Manager,
            Staff,
            Cashier
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HiretDateStart { get; set; }
        public DateTime HireDateEnd { get;set; }
        [Range(700,10000)]
        public int SallaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }
        public List<Transaction> TransactionList { get; set; }
        public Employee() { }
        public Employee(int id)
        {
           ID = id;
            HiretDateStart = DateTime.Now;
        }
    }
}
