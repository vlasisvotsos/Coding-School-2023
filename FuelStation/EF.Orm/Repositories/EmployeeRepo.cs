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
        public EmployeeRepo() { }
        public void Add(Employee employee)
        {
            using var context = new AppDbContext();
            context.Employees.Add(employee);
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

        public IEnumerable<Employee> GetAll()
        {
            using var context = new AppDbContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Employees.SingleOrDefault(employee => employee.ID == id);
        }

        public void Update(int id, Employee employee)
        {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
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
