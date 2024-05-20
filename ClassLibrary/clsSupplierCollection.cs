using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mSupplier = new clsSupplier();

        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();

                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ASupplier.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ASupplier.DateReg = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateReg"]);

                mSupplierList.Add(ASupplier);
                Index++;
            }
        }

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mSupplier;
            }
            set
            {
                mSupplier = value;
            }
        }
    }
}
