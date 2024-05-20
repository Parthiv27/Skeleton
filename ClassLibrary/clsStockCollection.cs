using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    
    public class clsStockCollection
    {
        public clsStockCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;
           
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;
           
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();

                AnStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AnStock.Producttype = Convert.ToString(DB.DataTable.Rows[Index]["Producttype"]);
                AnStock.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                AnStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AnStock.Restockneeded = Convert.ToBoolean(DB.DataTable.Rows[Index]["Restockneeded"]);
                AnStock.Daterestocked = Convert.ToDateTime(DB.DataTable.Rows[Index]["Daterestocked"]);
                AnStock.Discontinued = Convert.ToBoolean(DB.DataTable.Rows[Index]["Discontinued"]);

                mStockList.Add(AnStock);

                Index++;
            }

        }


        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }




        public clsStock ThisStock { get; set; }
    }

 




}