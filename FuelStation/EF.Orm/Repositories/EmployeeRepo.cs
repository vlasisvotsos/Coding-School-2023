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
    public class EmployeeRepo
    {
        public void Add(Employee employee)
        {
            using var context = new AppDbContext();
            context.Add(employee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbEmploee = context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
            if (dbEmploee is null)
            {
                return;
            }

            context.Remove(dbEmploee);
            context.SaveChanges();

        }

        public List<Employee> GetAll()
        {
            using var context = new AppDbContext();
            return context.Employees.Include(employee => employee.TransactionList).ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Employees.Where(employee => employee.ID == id).Include(employee => employee.TransactionList).SingleOrDefault();
        }

        public void Update(int id, Employee employee)
        {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
            if (dbEmployee is null)
            {
                return;
            }
            dbEmployee.Name= employee.Name;
            dbEmployee.Surname= employee.Surname;
            dbEmployee.HiretDateStart= employee.HiretDateStart;
            dbEmployee.HireDateEnd= employee.HireDateEnd;
            dbEmployee.SallaryPerMonth= employee.SallaryPerMonth;
            dbEmployee.EmployeeType= employee.EmployeeType;
            context.SaveChanges();
        }
    }
}
