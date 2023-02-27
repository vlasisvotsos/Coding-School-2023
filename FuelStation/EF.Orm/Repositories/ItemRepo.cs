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
    public class ItemRepo
    {
        public void Add(Item item)
        {
            using var context = new AppDbContext();
            context.Items.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AppDbContext();
            var dbItem = context.Items.Where(item => item.ID == id).SingleOrDefault();
            if (dbItem is null)
            {
                return;
            }

            context.Remove(dbItem);
            context.SaveChanges();

        }

        public List<Item> GetAll()
        {
            using var context = new AppDbContext();
            return context.Items.ToList();
        }

        public Item? GetById(int id)
        {
            using var context = new AppDbContext();
            return context.Items.SingleOrDefault(item => item.ID == id);
        }

        public void Update(int id, Item item)
        {
            using var context = new AppDbContext();
            var dbItem = context.Items.SingleOrDefault(item => item.ID == id);
            if (dbItem is null)
            {
                return;
            }
            dbItem.Code= item.Code;
            dbItem.Description= item.Description;
            dbItem.ItemType= item.ItemType;
            dbItem.Price= item.Price;
            dbItem.Cost= item.Cost;
            context.SaveChanges();
        }

    }
}
