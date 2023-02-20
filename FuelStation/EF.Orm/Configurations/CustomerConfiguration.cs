﻿using EF.Model;
using EF.Orm.ValueGenarator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Orm.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).ValueGeneratedOnAdd();
            builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(customer => customer.Surname).HasMaxLength(50).IsRequired(true);
            builder.Property(customer => customer.CardNumber).HasValueGenerator<CustomerCardNumberGenerator>();
        }
    }
}
