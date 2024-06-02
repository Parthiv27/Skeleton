using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //crreate a new instance of cls customer
        clsCustomer ACustomer = new clsCustomer();
        //capture the first name
        string FirstName = txtFirstName.Text;
        //capture the surname
        string SurName = txtSurName.Text;
        //Capture email
        string Email = txtEmail.Text;
        //capture Address
        string Address = txtAddress.Text;
        //capture the verified checkbox
        string Active = chkActive.Text;
        //capture date joined
        string DateJoined = txtDateJoined.Text;
        //store the erre messages
        string Error = "";
        //navigate to the view page 
        Error = ACustomer.Valid(FirstName, Email, SurName, Address, DateJoined);
        if (Error == "")
        {
            //capture the first name
            ACustomer.FirstName = FirstName;
            ACustomer.SurName = SurName;
            ACustomer.Address = Address;
            ACustomer.Email = Email;
            ACustomer.DateJoined = Convert.ToDateTime(DateJoined);
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}
