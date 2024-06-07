using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }

        public string UserName
        {
            get
            {
                //return the private data 
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@UserName", UserName);

            DB.AddParameter("@Password", Password);

            DB.Execute("sproc_tblUsers_FindUsernamePW");

            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["userID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}