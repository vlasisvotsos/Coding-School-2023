using Backend.Models.Enums;


namespace Backend.Models
{
    public class Employee
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HiretDateStart { get; set; }
        public DateTime HireDateEnd { get;set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        public Employee()
        {
            ID = Guid.NewGuid();
            HiretDateStart = DateTime.Now;
        }
    }
}
