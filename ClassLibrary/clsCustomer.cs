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
        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set 
            {
                mLastName = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private string mAddress;
        public string Address
        {
            get
            { 
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
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
            mFirstName = "Test First Name";
            mLastName = "Test Last Name";
            mEmail = "Test Email";
            mAddress = "Test Address";
            return true;
            

        }
    }



    }
