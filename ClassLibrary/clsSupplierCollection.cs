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
        clsSupplier mThisSupplier = new clsSupplier();

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
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
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@DateReg", mThisSupplier.DateReg);
            DB.AddParameter("@Active", mThisSupplier.Active);

            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierEmail(string SupplierEmail)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierEmail", SupplierEmail);
            DB.Execute("sproc_tblSupplier_FilterBySupplierEmail");

            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@DateReg", mThisSupplier.DateReg);
            DB.AddParameter("@Active", mThisSupplier.Active);

            DB.Execute("sproc_tblSupplier_Update");
        }
    }
}
