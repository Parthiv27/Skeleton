using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        Error = AnOrders.Valid(CustomerName, StockItem, DispatchDate, Description, Price, Dispatched);
        if (Error == "")
        {
            //capture customer name
            AnOrders.CustomerName = CustomerName;
            //capture stock item
            AnOrders.StockItem = StockItem;
            //capture price
            AnOrders.Price = Price;
            //capture Dispatch date
            AnOrders.DispatchDate = Convert.ToDateTime(DispatchDate);
            //store the order in the session object
            Session["AnOrders"] = AnOrders;
            //navigate to the view page
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

