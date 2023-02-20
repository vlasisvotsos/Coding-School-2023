using EF.Model;
using EF.Orm.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Orm.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get;set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionsLines { get; set; }
        public DbSet<Ledger> Ledgers { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.Entity<Customer>().Property(customer => customer.ID).ValueGeneratedOnAdd();
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.Entity<Item>().Property(item => item.ID).ValueGeneratedOnAdd();
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.Entity<Employee>().Property(employee => employee.ID).ValueGeneratedOnAdd();
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.Entity<Transaction>().Property(transaction => transaction.ID).ValueGeneratedOnAdd();
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            modelBuilder.Entity<TransactionLine>().Property(transactionLine => transactionLine.ID).ValueGeneratedOnAdd();
            modelBuilder.ApplyConfiguration(new LedgerConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FuelStation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
