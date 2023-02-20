using EF.Orm.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Orm.ValueGenarator
{
    public class CustomerCardNumberGenerator : ValueGenerator<String>
    {
        public override bool GeneratesTemporaryValues => false;
        private readonly AppDbContext _context;

        public CustomerCardNumberGenerator()
        {
            _context = new AppDbContext();
        }

        private String NextCustomerCardNumber()
        {
            var lastCardNumber = _context.Customers
        .AsNoTracking()
        .FirstOrDefault()?.CardNumber;
            if (lastCardNumber == null)
            {
                return "A0000";
            }

            var currentCardNumber = Increment.AlphaNumericValue(lastCardNumber);
            var customer = _context.Customers.FirstOrDefault();

            if (customer == null) return currentCardNumber;

            customer.CardNumber = currentCardNumber;

            _context.SaveChanges();

            return currentCardNumber;
        }

        public override string Next(EntityEntry entry) => NextCustomerCardNumber();

        protected override object NextValue(EntityEntry entry) => NextCustomerCardNumber();

    }
}
