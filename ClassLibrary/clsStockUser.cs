using System;

namespace ClassLibrary
{
    public class clsStockUser
    {

        private Int32 mUserId;

        private string mUsername;

        private string mPassword;

        private string mDepartment;


        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }
        public string UserName
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
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

        public bool FindUser(string username, string password)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);

            DB.Execute("sproc_tblUsers_FindUsernamePW");

            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
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