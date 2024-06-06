using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted 
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the orders to be deleted from the sessio n object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrdersCollection Orders = new clsOrdersCollection();

        Orders.ThisOrders.Find(OrderID);

            Orders.Delete();

        Response.Redirect("OrderList.aspx");
    }
}