﻿using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateJoined { get; set; }
        public bool Active { get; set; }

        public bool Find(int customerId)
        {
            //always return true
            return true;
        }



    }
}