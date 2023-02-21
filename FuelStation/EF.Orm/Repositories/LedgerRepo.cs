using EF.Model;
using EF.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Orm.Repositories
{
    public class LedgerRepo
    {
        public List<Ledger> GetAll()
        {
            using var context = new AppDbContext();
            return context.Ledgers.ToList();
        }

        public Ledger? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Ledgers.SingleOrDefault();
        }
    }
}
