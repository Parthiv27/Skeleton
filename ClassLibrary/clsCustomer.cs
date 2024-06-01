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
        private string mSurName;
        public string SurName
        {
            get
            {
                return mSurName;
            }
            set
            {
                mSurName = value;
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
        private Boolean mActive;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //reacte an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurName = Convert.ToString(DB.DataTable.Rows[0]["SurName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;


            }
            else
            {
                return false;
            }
        }

        public string Valid(string firstName, string email, string surName, string address, object dateJoined)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the first name is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name may not be blank : ";
            }
            //if the first name is greater than 24 characters
            if (firstName.Length > 24)
            {
                //record the error
                Error = Error + "The First Name should not be more than 24 characters";
            }
            //copy the dateadded value to the datetemp variable
            DateTemp = Convert.ToDateTime(DateJoined);
            //check to see if the date is then todays date
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than todays date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            
            return Error;
        }
    }
}




