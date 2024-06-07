using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is the not new record
            if(OrderID != -1)
            {
                //display the current data for the reord
                DisplayOrders();
            }
        }
    }
    void DisplayOrders()
    {
        //create an instance of the class we want to create
        clsOrdersCollection OrderBook = new clsOrdersCollection();
        //find the record to update
        OrderBook.ThisOrders.Find(OrderID);
        //display the data for the record
        txtOrderID.Text = OrderBook.ThisOrders.OrderID.ToString();
        txtCustomerName.Text = OrderBook.ThisOrders.CustomerName.ToString();
        txtStockItem.Text = OrderBook.ThisOrders.StockItem.ToString();
        txtDescription.Text = OrderBook.ThisOrders.Description.ToString();
        txtDispatchtDate.Text = OrderBook.ThisOrders.DispatchDate.ToString();
        txtPrice.Text = OrderBook.ThisOrders.Price.ToString();
        chkDispatched.Checked = OrderBook.ThisOrders.Dispatched;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsOrders AnOrders = new clsOrders();

        string CustomerName = txtCustomerName.Text;
        string StockItem = txtStockItem.Text;
        string Description = txtDescription.Text;
        string Dispatched = chkDispatched.Text;
        string Price = txtPrice.Text;
        string DispatchDate = txtDispatchtDate.Text;
        string Error = "";
        Error = AnOrders.Valid(CustomerName, StockItem, Description, DispatchDate, Price);
        if (Error == "")
        {
            AnOrders.OrderID = OrderID;
            AnOrders.CustomerName = CustomerName;
            AnOrders.StockItem = StockItem;
            AnOrders.Price = Convert.ToInt32(Price);
            AnOrders.DispatchDate = Convert.ToDateTime(DispatchDate);
            AnOrders.Dispatched = chkDispatched.Checked;
            AnOrders.Description = Description;


            clsOrdersCollection OrdersList = new clsOrdersCollection();

            if (OrderID == 1)
            {
                OrdersList.ThisOrders = AnOrders;

                OrdersList.Add();
            }
            else
            {
                OrdersList.ThisOrders.Find(OrderID);

                OrdersList.ThisOrders = AnOrders;

                OrdersList.Update();
            }

            Response.Redirect("OrderList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }








    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrders AnOrders = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the reulst of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrders.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerName.Text = AnOrders.CustomerName;
            txtStockItem.Text = AnOrders.StockItem;
            txtDescription.Text = AnOrders.Description;
            txtPrice.Text = AnOrders.Price.ToString();
            chkDispatched.Checked = AnOrders.Dispatched;
            txtOrderID.Text = AnOrders.OrderID.ToString();
        }



    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLisr.aspx");
    }
}

