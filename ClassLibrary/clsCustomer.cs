using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data memeber for the address id property
        private Int32 mCustomerId;
        //ustomcer id public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        private DateTime mDateJoined;
        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }
       
        public bool Active { get; set; }

        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 21;
            mDateJoined = Convert.ToDateTime("23/05/2024");
            return true;
            

        }
    }



    }
