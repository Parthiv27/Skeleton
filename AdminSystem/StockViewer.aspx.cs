using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        AnStock = (clsStock)Session["AnStock"];

        Response.Write(AnStock.StockId);
        Response.Write(AnStock.Producttype);
        Response.Write(AnStock.Size);
        Response.Write(AnStock.StockQuantity);
        Response.Write(AnStock.Restockneeded);
        Response.Write(AnStock.Daterestocked);
        Response.Write(AnStock.Discontinued);
    }
}