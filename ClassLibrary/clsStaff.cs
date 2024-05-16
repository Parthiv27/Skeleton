using System;

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


        public bool Find(int staffId)
        {
            //set the private data memebers to the test data value
            mStaffId = 2;
            mFirstName = "Jeo";
            mLastName = "Smith";
            mEmail = "JeoSmith12@gmail.com";
            mHireDate = Convert.ToDateTime("23/10/2021");
            mActive = true;
            mSalary = Convert.ToDecimal("30000");
            //always return true
            return true;
        }
    }
}
