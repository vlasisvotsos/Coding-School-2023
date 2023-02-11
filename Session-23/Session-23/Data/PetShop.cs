using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace Session_23
{
    public class PetShop : DbContext
    {
        public DbSet<Pet> Pets { get; set; } = null;
        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<Employee> Employees { get; set; } = null;
        public DbSet<MonthlyLedger> MonthlyLedger { get; set; } = null;
        public DbSet<PetFood> PetFood { get; set; } = null;
        public DbSet<Transaction> Transaction { get; set; } = null;
    }
}
