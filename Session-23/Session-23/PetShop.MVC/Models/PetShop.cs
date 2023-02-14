using PetShop.Model;

namespace PetShop.MVC.Models
{
    public class PetShop
    {
        List<Pet> Pets { get;set; }
        List<Customer> Customers { get;set; }
        List<Employee> Employees { get;set; }
        List<Transaction> Transactions { get;set; }
        List<PetFood> PetFoods { get;set; }
        List<MonthlyLedger> MonthlyLedger { get;set; }

        public PetShop() 
        {
            
        }
    }
}
