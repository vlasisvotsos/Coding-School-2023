using EF.Model;
using EF.Orm.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Orm.Repositories
{
    public class CustomerRepo
    {
        public void Add(Customer customer)
        {
            using var context = new AppDbContext();
            context.Add(customer);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                return;
            }

            context.Remove(dbCustomer);
            context.SaveChanges();

        }

        public IEnumerable<Customer> GetAll()
        {
            using var context = new AppDbContext();
            return context.Customers.ToList();            
        }

        public Customer? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public void Update(int id, Customer customer)
        {
            using var context = new AppDbContext();
            var dbCustomer = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if(dbCustomer is null)
            {
                return;
            }
            dbCustomer.Name = customer.Name;
            dbCustomer.Surname= customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;
            context.SaveChanges();
        }

    }

}
