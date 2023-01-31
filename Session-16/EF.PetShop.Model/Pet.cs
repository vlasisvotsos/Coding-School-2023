using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16 {
    public class Pet {
        public enum AnimalTypeEnum {
            Bird,
            Cat,
            Dog,
            None
        }
        public enum PetStatusEnum {
            OK,
            Unhealthy,
            Recovering
        }

        public Guid PetID { get; set; }
        public string Breed { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }
        public PetStatusEnum Status { get; set; }
        public double Price { get; set;}
        public double Cost { get; set; }
        public string AnimalBreed {
            get { return String.Format("{0} {1}", AnimalType, Breed); }
            set { Breed = value; }  
        }

        public Pet() {
            PetID=Guid.NewGuid();
            switch(AnimalType) {
                  
                    case AnimalTypeEnum.Cat:
                    Price = 100;
                    Cost= 80;
                    break;
                    case AnimalTypeEnum.Dog:
                    Price = 120;
                    Cost = 100;
                    break;
                    case AnimalTypeEnum.Bird:
                    Price= 200;
                    Cost= 150;
                    break;
            }
        }
    }
}

