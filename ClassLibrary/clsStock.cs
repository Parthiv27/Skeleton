using System;
using System.Linq.Expressions;

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


        private Boolean mDiscontinued;
        public bool Discontinued
        {
            get
            {
                return mDiscontinued;
            }
            set
            {
                mDiscontinued = value;
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
                mDiscontinued = Convert.ToBoolean(DB.DataTable.Rows[0]["Discontinued"]);

                return true;
            }

            else
            {

                return false;
            }



        }

        public string Valid(string Producttype, string Size, string Daterestocked, string StockQuantity)
        {
            String Error = "";

            DateTime DateTemp;


            if (Producttype.Length == 0)
            {
                Error = Error + "The Product type may not be blank : ";
            }

            if (Producttype.Length > 20)
            {
                Error = Error + "The Product type must not be less than 20 characters : ";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {

                DateTemp = DateTime.ParseExact(Daterestocked, "dd/MM/yyyy", null);
                if (DateTemp < DateComp.AddYears(-100))
                {
                    Error += "The date cannot be more than 100 years in the past : ";

                }

                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch (FormatException)
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (Size.Length == 0)
            {
                Error = Error + "The Size may not be blank : ";
            }

            if (Size.Length > 10)
            {
                Error = Error + "The Size must be less than 10 characters : ";
            }



            if (StockQuantity.Length == 0)
            {
                Error = Error + "The Stock Quantity may not be blank : ";
            }

            if (StockQuantity.Length > 50)
            {
                Error = Error + "The Stock Quantity must be less than 50 characters : ";
            }

            return Error;
        }









    }

}
        
            
        
       





        



  
