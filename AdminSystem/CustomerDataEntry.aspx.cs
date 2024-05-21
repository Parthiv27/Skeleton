using System;
using System.Collections.Generic;
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
        ACustomer.FirstName = txtFirstName.Text;
        //capture the surname
        ACustomer.LastName = txtLastName.Text;
        //Capture email
        ACustomer.Email = txtEmail.Text; 
        //capture Address
        ACustomer.Address = txtAddress.Text;
        //capture the verified checkbox
        ACustomer.Active = chkActive.Checked;
        //capture date joined
        ACustomer.DateJoined = Convert.ToDateTime(DateTime.Now); 
        //store the first name in the session
        Session["ACustomer"] = ACustomer;
        //navigate to the view page 
        Response.Redirect("CustomerViewer.aspx");
    }
}