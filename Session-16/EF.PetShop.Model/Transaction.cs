using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_16 {
    public class Transaction {
        public Guid TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public double PetPrice { get; set; }
        public Guid PetFoodID { get; set; }
        public double PetFoodQty { get; set; }
        public double PetFoodPrice { get; set; }
        public double TotalPrice { get; set; }

        public Transaction(Pet pet, Customer customer) {
            PetFood petFood = new PetFood(pet);
            TransactionID = Guid.NewGuid();            
            TransactionDate = DateTime.Now;
            PetID = pet.PetID;
            PetFoodID = petFood.PetFoodID;
            CustomerID = customer.CustomerID;
            PetPrice = pet.Price;
            PetFoodPrice = petFood.Price;
            TotalPrice = PetPrice + PetFoodPrice*(PetFoodQty -1);
        }
    }
}
