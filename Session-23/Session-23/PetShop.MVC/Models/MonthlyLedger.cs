﻿namespace PetShop.MVC.Models
{
    public class MonthlyLedger
    {
        public DateTime Year { get; set; }
        public DateTime Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        MonthlyLedger() 
        {

        }

    }
}
