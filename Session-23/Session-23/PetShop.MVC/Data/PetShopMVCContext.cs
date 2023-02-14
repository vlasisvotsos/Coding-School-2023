using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShop.Model;
using PetShop.MVC.Models;

namespace PetShop.MVC.Data
{
    public class PetShopMVCContext : DbContext
    {
        public PetShopMVCContext (DbContextOptions<PetShopMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;

        public DbSet<Employee> Employee { get; set; } = default!;

        public DbSet<Pet> Pet { get; set; } = default!;

        public DbSet<PetFood> PetFood { get; set; } = default!;

        public DbSet<Transaction> Transaction { get; set; } = default!;

        public DbSet<MonthlyLedger> MonthlyLedger { get; set; } = default!;
    }
}
