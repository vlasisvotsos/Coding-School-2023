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
    public class TransactionRepo
    {
        public void Add(Transaction transaction)
        {
            using var context = new AppDbContext();
            context.Add(transaction);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (dbTransaction is null)
            {
                return;
            }

            context.Remove(dbTransaction);
            context.SaveChanges();

        }

        public List<Transaction> GetAll()
        {
            using var context = new AppDbContext();
            return context.Transactions.Include(transaction => transaction.TransactionLineList).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Transactions.Where(transaction => transaction.ID == id).Include(transaction => transaction.TransactionLineList).SingleOrDefault();
        }

        public void Update(int id, Transaction transaction)
        {
            using var context = new AppDbContext();
            var dbTransaction = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (dbTransaction is null)
            {
                return;
            }
            dbTransaction.Date= transaction.Date;
            dbTransaction.Employee= transaction.Employee;
            dbTransaction.Customer= transaction.Customer;
            dbTransaction.PaymentMethod= transaction.PaymentMethod;
            context.SaveChanges();
        }
    }
}
