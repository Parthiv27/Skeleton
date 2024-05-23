﻿using System;
using System.IO;

namespace ClassLibrary
{
    public class clsOrders
    {

        private double mPrice;
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }

        private Boolean mDispatched;
        public Boolean Dispatched
        {
            get
            {
                return Dispatched;
            }
            set
            {
                Dispatched = value;
            }
        }


        private DateTime mDispatchDate;
        public DateTime DispatchDate
        {
            get
            {
                return DispatchDate;

            }
            set
            {
                DispatchDate = value;
            }
        }
        //private data for member for the Order id property
        private Int32 mOrderID;
        //OrderID public property

        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out the the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }

        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return CustomerName;
            }
            set
            {
                CustomerName = value;
            }
        }
        private string mStockItem;
        public string StockItem
        {
            get
            {
                return StockItem;
            }
            set
            {
                StockItem = value;
            }
        }
        private string mDescription;
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }

        public string name { get; set; }

        /********* FIND METHOD ************/
        public bool Find(int OrderID)
        {
            //create an instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramater for the item ID to search for
            DB.AddParameter("@itemId", OrderID);
            //add execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            // if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispached"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mDispatchDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DispatchDate"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStockItem = Convert.ToString(DB.DataTable.Rows[0]["StockItem"]);
            }
            //set the private data members to the test data value 
            mOrderID = 21;
            mDispatchDate = Convert.ToDateTime("02/06/2004");
            //always return true
            return true;
        }

        public string Valid(string stockItem, string CustomerName)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the house is blank
            if (CustomerName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer name  may not be blank : ";
            }
            // if the price is greater than 100
            if (CustomerName.Length > 60)
            {
                //record the Error
                Error = Error + "The customer name must be less than 60 ; ";
            }
            //copy the dateadded value to the datetemp variable
            DateTemp = Convert.ToDateTime(DispatchDate);
            //check to see if the date is less than todays date 
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }
            //return any error messages
            return Error;
            if (StockItem.Length == 0)
            {
                //record the error
                Error = Error + "The stock Item must not be blank:";
            }

        }

        public string Valid(string customerName, string stockItem, string dispatchDate, string description, string price, string dispatched)
        {
            throw new NotImplementedException();
        }
    }
}