using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public bool Active { get; set; }
    }
}