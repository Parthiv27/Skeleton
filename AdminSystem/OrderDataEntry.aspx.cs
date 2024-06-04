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
        //create a new instance of cls orders
        clsOrders AnOrders = new clsOrders();
        //capture the CustomerName
        string CustomerName = txtCustomerName.Text;
        //capture StockItem
        string StockItem = txtStockItem.Text;
        //capture price
        string Price = txtPrice.Text;
        //capture DispatchDate
        string DispatchDate = txtDispatchtDate.Text;
        //capture description
        string Description = txtDescription.Text;
        //capture Dispatched
        bool Dispatched = chkDispatched.Checked;
        string Error = "";
        //validate the data
        Error = AnOrders.Valid(CustomerName, StockItem, DispatchDate, Description, Price);
        if (Error == "")
        {
            //capture OrderID
            AnOrders.OrderID = OrderID; //dont miss this
            //capture customer name
            AnOrders.CustomerName = CustomerName;
            //capture stock item
            AnOrders.StockItem = StockItem;
            //capture description 
            AnOrders.Description = Description;
            //capture price
            AnOrders.Price = Convert.ToDouble(Price);
            //capture Dispatch date
            AnOrders.DispatchDate = Convert.ToDateTime(DispatchDate);
            //capture dispatched
            AnOrders.Dispatched = chkDispatched.Checked;
            //create a new instance of the order collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();
            //if this is a new record i.e OrderID = -1 then add the data
            if (OrderID == -1)
            {
                //set the this order property
                OrdersList.ThisOrders = AnOrders;
                //add the new record
                OrdersList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrdersList.ThisOrders.Find(OrderID);
                //set the ThisOrders property
                OrdersList.ThisOrders = AnOrders;
                //update the record
                OrdersList.Update();
            }
            //redirect back to the list page
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }




        // capture CustomerName 
        AnOrders.CustomerName = txtCustomerName.Text;

        //capture Shoe
        AnOrders.StockItem = txtStockItem.Text;
        //store the order in the session objective
        Session["AnOrders"] = AnOrders;

        //navigate to the view page
        Response.Redirect("OrderViewer");


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


}

