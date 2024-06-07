using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayCustomer();
        }

        clsCustomerUser AnUser = new clsCustomerUser();

        AnUser = (clsCustomerUser)Session["AnUser"];

        Response.Write("Logged in as: " + AnUser.UserName);

    }

    void DisplayCustomer()
    {
        // Create an instance of the class we want to create 
        clsCustomerCollection Customer = new clsCustomerCollection();
        // Set the data source to the list of staff in the collection
        lstCustomerList.DataSource = Customer.CustomerList;
        // Set the data value field of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        // Set the data field to display
        lstCustomerList.DataTextField = "FirstName";
        // Bind the data to the list 
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store  -1 into the session object to indicate this new record 
        Session["CustomerId"] = -1;
        //redirect to the data enrty page
        Response.Redirect("CustomerDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of record to be edited
        Int32 CustomerId;
        //if a recod has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primarykey value of the ecord to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session obejct
            Session["CustomerId"] = CustomerId;
            //redirect to edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else  //if no record has been selected
        {
            lblError.Text = "Please Select a record from the list to edit";

        }
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of record to be edited
        Int32 CustomerId;
        //if a recod has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primarykey value of the record to delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session obejct
            Session["CustomerId"] = CustomerId;
            //redirect to edit page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else  //if no record has been selected
        {
            lblError.Text = "Please Select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to create
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        //retrive the value of first name from presention layer
        ACustomer.ReportByFirstName(txtFirstName.Text);
        //set the data source to the list of staffin the collection
        lstCustomerList.DataSource = ACustomer.CustomerList;
        //set the name of primary keu=y
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the filed to display
        lstCustomerList.DataTextField = "FirstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the class we want to create
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        // set an empty string
        ACustomer.ReportByFirstName("");
        // clear any existing filter to tidy up the interface
        txtFirstName.Text = "";
        // set the data source to the list of staff in the collection
        lstCustomerList.DataSource = ACustomer.CustomerList;
        // set the name of primary key
        lstCustomerList.DataValueField = "CustomerId";
        // set the name of the field to display
        lstCustomerList.DataTextField = "FirstName";
        // bind the data to the list
        lstCustomerList.DataBind();
    }


    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        //rediret to the main page 
        Response.Redirect("TeamMainMenu.aspx");
    }
}