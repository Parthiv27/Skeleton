using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private int mSupplierID;
        private String mSupplierName;
        private String mEmail;
        private String mPhone;
        private DateTime mDateReg;
        private Boolean mActive;


        public int SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID= value;
            }
        }

        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName= value;
            }
        }

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
        public DateTime DateReg
        {
            get
            {
                return mDateReg;
            }
            set
            {
                mDateReg = value;
            }
        }

        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }

        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mDateReg = DateTime.Now.Date;
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
