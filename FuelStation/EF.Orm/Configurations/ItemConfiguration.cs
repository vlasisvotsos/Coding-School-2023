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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {            
            builder.ToTable("Items");
            builder.HasKey(item => item.ID);
            builder.Property(item => item.ID).ValueGeneratedOnAdd();
            builder.Property(item => item.Price).HasPrecision(12, 2);
            builder.Property(item => item.Cost).HasPrecision(12, 2);
            builder.HasOne(transaction => transaction.Transaction)
            .WithMany(item => item.ItemList);
        }
    }
}
