using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //priavte data member for thisAddress
        clsStock mThisStock = new clsStock();   
        public clsStockCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            PopulateArray(DB);          

        }


        
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




        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Producttype", mThisStock.Producttype);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@Restockneeded", mThisStock.Restockneeded);
            DB.AddParameter("@Daterestocked", mThisStock.Daterestocked);
            DB.AddParameter("@Discontinued", mThisStock.Discontinued);

            return DB.Execute("sproc_tblStock_Insert");


        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockId", mThisStock.StockId);

            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByProducttype(string Producttype)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Producttype", Producttype);

            DB.Execute("sproc_tblStock_FilterByProducttype");

            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@Producttype", mThisStock.Producttype);
            DB.AddParameter("@Size", mThisStock.Size);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@Restockneeded", mThisStock.Restockneeded);
            DB.AddParameter("@Daterestocked", mThisStock.Daterestocked);
            DB.AddParameter("@Discontinued", mThisStock.Discontinued);

            DB.Execute("sproc_tblStock_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mStockList = new List<clsStock>();


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


    }






}