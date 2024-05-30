using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class SupplierLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsSupplierUser AnAdmin = new clsSupplierUser();

        string Username = txtUsername.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;

        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = AnAdmin.FindUser(Username, Password);
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter User Name ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter Password";
        }

        else if (Found == true)
        {
            Response.Redirect("SupplierList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Details are wrong.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}