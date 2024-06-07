using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsOrderUser AnUser = new clsOrderUser();
        string UserName = txtUsername.Text;
        string Password = TxtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(TxtPassword.Text); 
        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;
        if (txtUsername.Text == "") 
        {
            //record the error
            LblError.Text = "Please enter a UserName";
        }
        
        else if (TxtPassword.Text == "") 
        {
            LblError.Text = "Please enter a password";
        }
        //if found
        else if (Found == true)
        {
            Response.Redirect("OrderList.aspx");
        }
        else if (Found == false)
        {
            LblError.Text = "The login details are incorrect. Please try again";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}