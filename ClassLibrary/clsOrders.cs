using System;
using System.Data.Common;
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
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        private Boolean mDispatched;
        public Boolean Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }


        private DateTime mDispatchDate;
        public DateTime DispatchDate
        {
            get
            {
                return mDispatchDate;

            }
            set
            {
                mDispatchDate = value;
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

        private String mCustomerName;
        public String CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        private String mStockItem;
        public String StockItem
        {
            get
            {
                return mStockItem;
            }
            set
            {
                mStockItem = value;
            }
        }
        private String mDescription;
        public String Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

       

        /********* FIND METHOD ************/
        public bool Find(int OrderID)
        {
            //create an instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramater for the item ID to search for
            DB.AddParameter("@OrderID", OrderID);
            //add execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            //sproc_tblOrders_SelectAll
            // if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mDispatchDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DispatchDate"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStockItem = Convert.ToString(DB.DataTable.Rows[0]["StockItem"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                //return everything that works OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        //VALIDATION METHOD

        public string Valid(string CustomerName, string StockItem, string DispatchDate, string Description, string Price)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the Customername is blank
            if (CustomerName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer name  may not be blank : ";
            }
            
            if (CustomerName.Length < 30)
            {
                
                    Error = Error + "The customer name must be more than 40 characters :";
            }
            if (CustomerName.Length > 50)
            {
                //record the Error
                Error = Error + "The customer name must be less than 50 : ";
            }

            //create an instance of DateTime to compare with the datetemp
            //in th if stataement
            DateTime DateComp = DateTime.Now.Date;
            try
            {

                //copy the DispatchDate value to the datetemp variable
                DateTemp = Convert.ToDateTime(DispatchDate);
                if (DateTemp < DateComp) //compare DispatchDate with date
                {
                    //record the no error
                    Error = Error + "the date cannot be in the past :";
                }
                //chech to see if the date is greate that todays date
                if (DateTemp > DateComp) 
                {
                    //record the erro
                    Error = Error + "the date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date :";
            }

            {
                Error = Error + "The date cannot be in the past : ";
            }
            if (StockItem.Length == 0)
            {
                //record the error
                Error = Error + "The stock Item must not be blank:";
            }
            if (StockItem.Length > 25)
            {
                //record the error
                Error = Error + "The stock item must be less than 25 characters:";
            }
            if (StockItem.Length < 10)
            {
                //record the error
                Error = Error + "The StockItem must be more than 10 characters :";
            }
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + "The Description must not be blank:";
            }
            if (Description.Length > 50)
            {
                //record the error
                Error = Error + "The description must be less than 50 characters:";
            }
            if (Description.Length < 25)
            {
                //record the error
                Error = Error + "the description must be more than 30 characters :";
            }
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "the price amount must not be black";
            }
            //return any error messages
            return Error;
        }
    }
}