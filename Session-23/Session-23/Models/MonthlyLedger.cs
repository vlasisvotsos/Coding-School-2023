using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class MonthlyLedger
    {
        DateTime Year { get; set; }
        DateTime Month { get; set; }
        decimal Income { get; set; }
        decimal Expenses { get; set; }
        decimal Total { get; set; }
       
        public MonthlyLedger(DateTime year,DateTime month,decimal income,decimal expenses,decimal total) 
        { 
            Year= year;
            Month= month;
            Income= income;
            Expenses= expenses;
            Total= total;
        }

    }
}
