using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int StockId { get; set; }
        public string Producttype { get; set; }
        public string Size { get; set; }
        public int StockQuantity { get; set; }
        public bool Restockneeded { get; set; }
        public DateTime Daterestocked { get; set; }
        public bool Discontinued { get; set; }

        public bool Find(int stockId)
        {
            return true;
        }
    }
}