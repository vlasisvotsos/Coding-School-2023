using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16
{
    public class PetFood {
        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog,
            None
        }
        public Guid PetFoodID { get; set; } 
        public AnimalTypeEnum AnimalType { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        public PetFood() {
            PetFoodID= Guid.NewGuid();
            switch (AnimalType)
            {

                case AnimalTypeEnum.Cat:
                    Price = 8;
                    Cost = 5;
                    break;
                case AnimalTypeEnum.Dog:
                    Price = 7;
                    Cost = 2;
                    break;
                case AnimalTypeEnum.Bird:
                    Price = 6;
                    Cost = 3;
                    break;
            }
        }
    }
}
