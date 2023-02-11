using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace Session_23
{
    public class PetShop : DbContext
    {
        public DbSet<Pet> Pets { get; set; } = null;
        public DbSet<Customer> customers { get; set; } = null;
        public DbSet<Employee> employees { get; set; } = null;
        public DbSet<MonthlyLedger> monthlyLedger { get; set; } = null;
        public DbSet<PetFood> petFood { get; set; } = null;
        public DbSet<Transaction> transaction { get; set; } = null;
    }
}
