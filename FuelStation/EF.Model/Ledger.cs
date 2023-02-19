namespace EF.Model
{
    public class Ledger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public Ledger() 
        {
            
        }
    }
}
