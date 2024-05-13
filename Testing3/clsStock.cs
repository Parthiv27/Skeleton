using System;

namespace Testing3
{
    public class clsStock
    {
        public int StockId { get; internal set; }
        public string Producttype { get; internal set; }
        public string Size { get; internal set; }
        public int StockQuantity { get; internal set; }
        public bool Restockneeded { get; internal set; }
        public DateTime Daterestocked { get; internal set; }
        public bool Discontinued { get; internal set; }
    }
}