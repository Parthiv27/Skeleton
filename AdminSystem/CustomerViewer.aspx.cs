using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of a clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the sessiomn object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the first name of the customer
        Response.Write(ACustomer.FirstName);
        //Display the last name of the customer
        Response.Write(ACustomer.LastName);
        //display the email of the customer
        Response.Write(ACustomer.Email);
        //display the address of the customer
        Response.Write(ACustomer.Address);
        //display the check
        Response.Write(ACustomer.Active);
        //DISPLAY THE DATE
        Response.Write(ACustomer.DateJoined);

    }
}