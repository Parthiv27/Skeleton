using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        //If this is the first time page is displayed
        if (!IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
        clsOrderUser AnUser = new clsOrderUser();
        AnUser = (clsOrderUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);


    }
    void DisplayOrders()
    {
        //create an instance of the orders collection
        clsOrdersCollection AnOrders = new clsOrdersCollection();
        //set the date source to list of orders in the collection

        lstOrderList.DataSource = AnOrders.OrdersList;

        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "CustomerName";
        //bind the data to the list
        lstOrderList.DataBind();
    }
 
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["OrderID"] = 0;
        //redirect to the data entry page 
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record  has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //GET THE PRIMARY KEY ALUE OF TVHE RECORD DELETE
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page 
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Order object
        clsOrdersCollection AnOrders = new clsOrdersCollection();
        //retrieve the value of customer name from the presentatipon layer
        AnOrders.ReportByCustomerName(txtFilter.Text);
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = AnOrders.OrdersList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //SET THE NEW NAME OF THE FIELD TO DISPLAY
        lstOrderList.DataTextField = "CustomerName";
        //bind the data to the list
        lstOrderList.DataBind();
    }



    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create a new instance of the Order object
        clsOrdersCollection AnOrders = new clsOrdersCollection();
        //set an empty string
        AnOrders.ReportByCustomerName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = AnOrders.OrdersList;
        //set the name of the primary key 
        lstOrderList.DataValueField = "OrderID";
        //set the name of the field to display 
        lstOrderList.DataTextField = "CustomerName";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}