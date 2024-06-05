using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection() 
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array
            PopulateArray(DB);
            
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //READ IN THE FEILD for the current reccord
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.SurName = Convert.ToString(DB.DataTable.Rows[Index]["SurName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList

        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {//later 
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }


        public int Add()
        {
            //adds arcord to the database based on the values of the mThisCustomer
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //SET THE PARAMETER FOR THE STORED PROCEDURE
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SurName", mThisCustomer.SurName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisncustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the nw procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SurName", mThisCustomer.SurName);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Active", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {

            //update an existing record based on the values of thisncustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
        public void ReportByFirstName(string FirstName)
        {
            //filters the record based on a full or partial first name
            //connect to the databases
            clsDataConnection DB = new clsDataConnection();
            //send the firstname paramter to the database
            DB.AddParameter("@FirstName", FirstName);
            //excute the store procedure
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            //populate the array list with the datatable
            PopulateArray(DB);

        }

    }
}