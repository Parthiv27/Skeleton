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

        if (IsPostBack == false)
        {
            DisplayOrders();
        }

        clsOrderUser AnUser = new clsOrderUser();

        AnUser = (clsOrderUser)Session["AnUser"];

        Response.Write("Logged in as: " + AnUser.UserName);
    }
    void DisplayOrders()
    {
        clsOrdersCollection Orders = new clsOrdersCollection();

        lstOrderList.DataSource = Orders.OrdersList;

        lstOrderList.DataValueField = "OrderID";

        lstOrderList.DataTextField = "CustomerName";

        lstOrderList.DataBind();
    }
 
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;

        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);

            Session["OrderID"] = OrderID;

            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);

            Session["OrderID"] = OrderID;

            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
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