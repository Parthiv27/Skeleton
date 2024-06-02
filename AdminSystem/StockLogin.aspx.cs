using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStockUser AnUser = new clsStockUser();

        string Username = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        Username = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnUser.FindUser(Username, Password);

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a Username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password ";
        }
        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}