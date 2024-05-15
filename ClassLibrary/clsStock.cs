using System;

namespace ClassLibrary
{
    public class clsStock
    {

        private Int32 mStockId;
        public Int32 StockId
        {
            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }


        private string mProducttype;
        public string Producttype
        {
            get
            {
                return mProducttype;
            }
            set
            {
                mProducttype = value;
            }
        }



        private string mSize;
        public string Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }

        private Int32 mStockQuantity;
        public Int32 StockQuantity
        {
           get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }
        }

        private Boolean mRestockneeded;
        public bool Restockneeded
        {
            get
            {
                return mRestockneeded;
            }
            set
            {
                mRestockneeded = value;
            }
        }


        private DateTime mDaterestocked;
        public DateTime Daterestocked
        {
            get
            {
                return mDaterestocked;
            }

            set 
            { 
                mDaterestocked = value;
            }
        }


        private Boolean mDissontinued;
        public bool Discontinued
        {
            get 
            { 
                return mDissontinued;
            }
            set
            {
                mDissontinued = value;
            }
            
        }



        public bool Find(int StockId)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockId", StockId);

            DB.Execute("sproc_tblStock_FilterByStockId");

            if (DB.Count == 1)

            {
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mProducttype = Convert.ToString(DB.DataTable.Rows[0]["Producttype"]);
                mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mRestockneeded = Convert.ToBoolean(DB.DataTable.Rows[0]["Restockneeded"]);
                mDaterestocked = Convert.ToDateTime(DB.DataTable.Rows[0]["Daterestocked"]);
                mDissontinued = Convert.ToBoolean(DB.DataTable.Rows[0]["Discontinued"]);

                return true;
            }

            else
            { 

                return false;
            }
   
           

        }
    }
}
        
            
        
       





        



  
