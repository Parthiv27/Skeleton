using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Private data member for the list 
        private List<clsStaff> mStaffList = new List<clsStaff>();
        //private memeber data for thisstaff
        clsStaff mThisStaff = new clsStaff();

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
        public clsStaff ThisStaff 
        {
            get
            {
                // Return the private data
                return mThisStaff;
            }
            set
            {
                // Set the private data
                mThisStaff = value;
            }
        }

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

        public int Add()
        {
            // a record to database baesd on values of this mThisStaff
            //connect to databse 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for store proedcure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            
            //exeute the query returnig the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // update an extising record based on the values of this staff
            //connect to databse 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for store proedcure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.AddParameter("@Salary", mThisStaff.Salary);

            //exeute the query returnig the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by this staff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the paramter for the store procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the store procedure
            DB.Execute("sproc_tblStaff_Delete");


        }
    }
}
