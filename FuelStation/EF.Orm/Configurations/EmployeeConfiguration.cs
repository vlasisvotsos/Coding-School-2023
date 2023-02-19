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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(employee => employee.Surname).HasMaxLength(50).IsRequired(true);
        }
    }
}
