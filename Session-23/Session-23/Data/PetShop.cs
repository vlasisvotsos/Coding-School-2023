using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace Session_23
{
    public class PetShop : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MonthlyLedger> MonthlyLedger { get; set; }
        public DbSet<PetFood> PetFood { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
