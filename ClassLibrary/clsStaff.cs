using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id property
        private Int32 mStaffId;

        //StaffId public Staff
        public Int32 StaffId
        {
            get
            {
                //this line of code send data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code alloww data into the property
                mStaffId = value;
            }
        }
        //private data member for the FirstName property
        private String mFirstName;

        //FirstName public property
        public String FirstName
        {
            get
            {
                //this line of code send data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code alloww data into the property
                mFirstName = value;
            }
        }

        //private data member for the LastName property
        private String mLastName;

        //FirstName public property
        public String LastName
        {
            get
            {
                //this line of code send data out of the property
                return mLastName;
            }
            set
            {
                //this line of code alloww data into the property
                mLastName = value;
            }
        }

        //private data member for the Email property
        private String mEmail;

        //FirstName public property
        public String Email
        {
            get
            {
                //this line of code send data out of the property
                return mEmail;
            }
            set
            {
                //this line of code alloww data into the property
                mEmail = value;
            }
        }


        //private data member for the hire date property
        private DateTime mHireDate;

        //HireDate public property
        public DateTime HireDate
        {
            get
            {
                //this line of code send data out of the property
                return mHireDate;
            }
            set
            {
                //this line of code alloww data into the property
                mHireDate = value;
            }
        }

        //private data member for the active property
        private Boolean mActive;

        //Active public property
        public Boolean Active
        {
            get
            {
                //this line of code send data out of the property
                return mActive;
            }
            set
            {
                //this line of code alloww data into the property
                mActive = value;
            }
        }

        //private data member for the active property
        private Decimal mSalary;

        //FirstName public property
        public Decimal Salary
        {
            get
            {
                //this line of code send data out of the property
                return mSalary;
            }
            set
            {
                //this line of code alloww data into the property
                mSalary = value;
            }
        }


        public bool Find(int StaffId)
        {
            //creat an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the paramter  for the Staff id  to search for 
            DB.AddParameter("@StaffId", StaffId);
            //execute the store procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there shoudl be either 1 or zero)
            if (DB.Count == 1)

            {

                //COPY THE DATA FROM THE DATABASE TO PRIVATE DATA MEMEBERS
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]); ;
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["Salary"]);
                //always return true
                return true;
            }
            //if no record was found 
            else
            {
                //retuen false indicating there is a prblem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string email, string hireDate, string salary)
        {

            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the firstname is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The firstname may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (firstName.Length > 25)
            {
                //record the error
                Error = Error + "The firstname must be less than 25 characters : ";
            }
            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the hiredate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(hireDate);
                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the  no error
                    Error = Error + " The date cannot be in the past :";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the last name blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The lastname may not be blank : ";
            }

            //if the last name is too long
            if (lastName.Length > 25)
            {
                //record the error
                Error = Error + "The lastname must be less than 25 characters : ";
            }
            //is the email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the email is too long
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }
            //is the salary amount is blank
            if (salary.Length == 0)
            {
                //record the error
                Error = Error + "The salary amount may not be blank : ";
            }
            //if the salary number is too long
            if (salary.Length > 50)
            {
                //record the error
                Error = Error + "The salary must be deimalc number : ";
            }
            //return any error messages
            return Error;
        }
    }
}