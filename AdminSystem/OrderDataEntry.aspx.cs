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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //reatec a new instance of clsOrders
        clsOrders AnOrders = new clsOrders ();
        // capture CustomerName 
        AnOrders.CustomerName = txtCustomerName.Text;
        //capture Shoe
        AnOrders.StockItem = txtStockItem.Text;
        //store the order in the session objective
        Session["AnOrders"]  = AnOrders;
        //navigate to the view page
        Response.Redirect("OrderViewer");
        AnOrders.DispatchDate = Convert.ToDateTime(clndrDispatchDate.SelectedDate);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrders AnOrders = new clsOrders ();
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
            txtStockItem.Text += AnOrders.StockItem;

        }
        


    }
}
