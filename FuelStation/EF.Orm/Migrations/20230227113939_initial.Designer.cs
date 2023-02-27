﻿// <auto-generated />
using System;
using EF.Orm.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF.Orm.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230227113939_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF.Model.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("EF.Model.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HiretDateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SallaryPerMonth")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("EF.Model.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemType")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<int?>("TransactionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TransactionID");

                    b.ToTable("Items", (string)null);
                });

            modelBuilder.Entity("EF.Model.Ledger", b =>
                {
                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<decimal>("Expenses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Year", "Month");

                    b.ToTable("Ledgers", (string)null);
                });

            modelBuilder.Entity("EF.Model.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("EF.Model.TransactionLine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NetValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TransactionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ItemID")
                        .IsUnique();

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionLines", (string)null);
                });

            modelBuilder.Entity("EF.Model.Item", b =>
                {
                    b.HasOne("EF.Model.Transaction", null)
                        .WithMany("ItemList")
                        .HasForeignKey("TransactionID");
                });

            modelBuilder.Entity("EF.Model.Transaction", b =>
                {
                    b.HasOne("EF.Model.Customer", "Customer")
                        .WithMany("TransactionList")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.Model.Employee", "Employee")
                        .WithMany("TransactionList")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EF.Model.TransactionLine", b =>
                {
                    b.HasOne("EF.Model.Item", "Item")
                        .WithOne("TransactionLine")
                        .HasForeignKey("EF.Model.TransactionLine", "ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.Model.Transaction", "Transaction")
                        .WithMany("TransactionLineList")
                        .HasForeignKey("TransactionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("EF.Model.Customer", b =>
                {
                    b.Navigation("TransactionList");
                });

            modelBuilder.Entity("EF.Model.Employee", b =>
                {
                    b.Navigation("TransactionList");
                });

            modelBuilder.Entity("EF.Model.Item", b =>
                {
                    b.Navigation("TransactionLine")
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Model.Transaction", b =>
                {
                    b.Navigation("ItemList");

                    b.Navigation("TransactionLineList");
                });
#pragma warning restore 612, 618
        }
    }
}