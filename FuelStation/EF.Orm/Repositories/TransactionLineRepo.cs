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
    public class TransactionLineRepo
    {
        public void Add(TransactionLine transactionLine)
        {
            using var context = new AppDbContext();
            context.Add(transactionLine);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbTransactionLine = context.TransactionsLines.Where(transactionLine => transactionLine.ID == id).SingleOrDefault();
            if (dbTransactionLine is null)
            {
                return;
            }

            context.Remove(dbTransactionLine);
            context.SaveChanges();

        }

        public List<TransactionLine> GetAll()
        {
            using var context = new AppDbContext();
            return context.TransactionsLines.Include(transactionLine => transactionLine.Item).ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.TransactionsLines.Where(transactionLine => transactionLine.ID == id).Include(transactionLine => transactionLine.Item).SingleOrDefault();
        }

        public void Update(int id, TransactionLine transactionLine)
        {
            using var context = new AppDbContext();
            var dbTransactionLine = context.TransactionsLines.Where(transactionLine => transactionLine.ID == id).SingleOrDefault();
            if (dbTransactionLine is null)
            {
                return;
            }
            
            dbTransactionLine.Transaction = transactionLine.Transaction;
            dbTransactionLine.Item = transactionLine.Item;
            dbTransactionLine.Quantity= transactionLine.Quantity;
            context.SaveChanges();
        }
    }
}
