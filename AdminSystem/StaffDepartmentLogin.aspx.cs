using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDepartmentLogin : System.Web.UI.Page
{

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an intance of the staff user class
        clsStaffUser AnUser = new clsStaffUser(); 
        //create the variable to store the username and password
        string UserName = txtUserName.Text; 
        string Password = txtPassword.Text; 
        //create a varibale to store the results of the filed user operation
        Boolean Found = false;  
        //get the username enterd by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password enterd by the user
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);    
        //if username and/or passwword is empty
        if (txtUserName.Text == "")
        {
            //record the error
            lblError.Text = "Enter a username";      
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Enter a Password";
        }
        //if found
        else if (Found == true)
        {
            //redirect to the list page
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect.Please try again";
        }
    }
}