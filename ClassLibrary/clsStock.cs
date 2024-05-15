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
            mDissontinued = false;
            mRestockneeded = true;
            mStockQuantity = 4;
            mSize = "5";
            mProducttype = "sneaker";
            mStockId = 3;
            mDaterestocked = Convert.ToDateTime("15/05/2024");
            return true;
        }
    }
}
        
            
        
       





        



  
