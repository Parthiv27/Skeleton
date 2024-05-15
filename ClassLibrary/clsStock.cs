using System;

namespace ClassLibrary
{
    public class clsStock
    {

        private Int32 mStockId;

        public Int32 StockId { get; set; }
        






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