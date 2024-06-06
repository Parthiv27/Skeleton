using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class clsOrdersCollection
    {
        List<clsOrders> mOrdersList = new List<clsOrders>();
       
        private clsOrders mThisOrders;

        //public property for the address list
        public List<clsOrders> OrdersList
        {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                //we shall worry about this later

            }
        }
        //public property for this orders
        public clsOrders ThisOrders
        {
            get
            {
                //return the private data
                return mThisOrders;
            }
            set
            {
                //set the private data
                mThisOrders = value;
            }
        }
        public clsOrdersCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            //get the count of records
            /*
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrders = new clsOrders();
                //read in the fields ofr the current record
                AnOrders.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrders.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrders.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrders.StockItem = Convert.ToString(DB.DataTable.Rows[Index]["StockItem"]);
                AnOrders.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnOrders.DispatchDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DispatchDate"]);
                AnOrders.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrders);
                //point at the next record
                Index++;
            }*/
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisOrders
            //connects to a database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisOrders.CustomerName);
            DB.AddParameter("@Description", mThisOrders.Description);
            DB.AddParameter("@Price", mThisOrders.Price);
            DB.AddParameter("@Dispatched", mThisOrders.Dispatched);
            DB.AddParameter("@DispatchDate", mThisOrders.DispatchDate);
            DB.AddParameter("@StockItem", mThisOrders.StockItem);
            //DB.AddParameter("@OrderID", mThisOrders.OrderID);

            //execute the query returning the priomary key
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisOrders
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderID", mThisOrders.OrderID);
            DB.AddParameter("@CustomerName", mThisOrders.CustomerName);
            DB.AddParameter("@Description", mThisOrders.Description);
            DB.AddParameter("StockItem", mThisOrders.StockItem);
            DB.AddParameter("@DispatchDate", mThisOrders.DispatchDate);
            DB.AddParameter("@Dispatched", mThisOrders.Dispatched);
            DB.AddParameter("@Price", mThisOrders.Price);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrders.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list 
            mOrdersList = new List<clsOrders>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrders = new clsOrders();
                //read in the fields ofr the current record
                AnOrders.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrders.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrders.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrders.StockItem = Convert.ToString(DB.DataTable.Rows[Index]["StockItem"]);
                AnOrders.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnOrders.DispatchDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DispatchDate"]);
                AnOrders.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrders);
                //point at the next record
                Index++;
            }
        }

        public void ReportByCustomerName(string CustomerName)
        {
            //filteres the record based on a full or partial customerName
            //connects to th edatabase
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByCustomerName");
            PopulateArray(DB);
        }
    }
}