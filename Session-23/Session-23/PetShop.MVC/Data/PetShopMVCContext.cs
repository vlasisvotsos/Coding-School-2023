using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace PetShop.MVC.Data
{
    public class PetShopMVCContext : DbContext
    {
        public PetShopMVCContext (DbContextOptions<PetShopMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PetShop.Model.Customer> Customer { get; set; } = default!;

        public DbSet<PetShop.Model.Employee> Employee { get; set; } = default!;

        public DbSet<PetShop.Model.Pet> Pet { get; set; } = default!;

        public DbSet<PetShop.Model.PetFood> PetFood { get; set; } = default!;

        public DbSet<PetShop.Model.Transaction> Transaction { get; set; } = default!;
    }
}
