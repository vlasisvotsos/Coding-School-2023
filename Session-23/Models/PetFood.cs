﻿using PetShop.Model.Enums;

namespace Session_23
{
    public class PetFood
    {
        public PetFood(AnimalType animalType, decimal price, decimal cost)
        {
            AnimalType = animalType;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
