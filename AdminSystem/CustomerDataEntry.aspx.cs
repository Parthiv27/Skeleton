using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //get the number of the customer to be processed
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the value of properties in the form 
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName.ToString();
        txtSurName.Text = CustomerBook.ThisCustomer.SurName.ToString();
        txtEmail.Text = CustomerBook.ThisCustomer.Email.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
        txtDateJoined.Text = CustomerBook.ThisCustomer.DateJoined.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.Active;
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
            //capture all parameters
            ACustomer.CustomerId = CustomerId;
            ACustomer.FirstName = FirstName;
            ACustomer.SurName = SurName;
            ACustomer.Address = Address;
            ACustomer.Email = Email;
            ACustomer.DateJoined = Convert.ToDateTime(DateJoined);
            ACustomer.Active = chkActive.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsCustomer ACustomer = new clsCustomer();
        //create a variable to store primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key enterd by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //Find the record 
        Found = ACustomer.Find(CustomerId);
        //if Found
        if (Found == true)
        {
            //display the value of properties in the form 
            txtCustomerId.Text = ACustomer.CustomerId.ToString();
            txtFirstName.Text = ACustomer.FirstName;
            txtSurName.Text = ACustomer.SurName;
            txtEmail.Text = ACustomer.Email;
            txtAddress.Text = ACustomer.Address;
            txtDateJoined.Text = ACustomer.DateJoined.ToString();
            chkActive.Checked = ACustomer.Active;

        }
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}
    

   