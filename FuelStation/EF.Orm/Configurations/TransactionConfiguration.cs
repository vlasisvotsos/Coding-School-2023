using EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Orm.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();
            builder.HasOne(employee => employee.Employee)
            .WithMany(transactions => transactions.TransactionList)
            .HasForeignKey(employee => employee.EmployeeID);
            builder.HasOne(customer => customer.Customer)
            .WithMany(transactions => transactions.TransactionList)
            .HasForeignKey(customer => customer.CustomerID);
        }
    }
}
