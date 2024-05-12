using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnFirstname = new clsOrders();
        //get data from session objective
        AnFirstname = (clsOrders)Session["AnFirstname"];
        //display the ID for this entry
        Response.Write (AnFirstname.Surname);
        Response.Write(AnFirstname.PostCode);
        Response.Write(AnFirstname.Shoe);
    }
}