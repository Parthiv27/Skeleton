using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Private data member for the list 
        private List<clsStaff> mStaffList = new List<clsStaff>();

        // Public property for StaffList
        public List<clsStaff> StaffList
        {
            get
            {
                // Return the private data
                return mStaffList;
            }
            set
            {
                // Set the private data
                mStaffList = value;
            }
        }

        // Public property for Count
        public int Count
        {
            get
            {
                // Return the private data
                return mStaffList.Count;
            }
            set
            {
                // We shall worry about this later
            }
        }

        // Public property for ThisStaff
        public clsStaff ThisStaff { get; set; }

        // Constructor for the class
        public clsStaffCollection()
        {
            //variable for index
            Int32 Index = 0;
            //varible to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to fetch data
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank staff object
                clsStaff staff = new clsStaff();
                //read in the fields for the current record
                staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                staff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                staff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                staff.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireDate"]); ;
                staff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                staff.Salary = Convert.ToDecimal(DB.DataTable.Rows[Index]["Salary"]);
                //add the record to the private data members
                mStaffList.Add(staff);
                //move to the next record
                Index++;
            }
        }

    }
}
