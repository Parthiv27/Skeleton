using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public string FirstName { get; set; }
        public string PostCode { get; set; }
        public DateTime DateAdded { get; set; }
        public string Surname { get; set; }
        public string Shoe { get; set; }

        public bool Find(int orderID)
        {
            //always return true 
            return true;
        }
    }
}