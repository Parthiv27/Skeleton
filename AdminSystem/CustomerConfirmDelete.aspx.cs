using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to create
        clsCustomerCollection Confirmation = new clsCustomerCollection();
        //find the record to delete 
        Confirmation.ThisCustomer.Find(CustomerId);
        //delete the record
        Confirmation.Delete();
        //redirect back main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back main page
        Response.Redirect("CustomerList.aspx");
    }
}