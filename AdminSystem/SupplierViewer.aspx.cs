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
        clsSupplier ASupplier = new clsSupplier();
        ASupplier = (clsSupplier)Session["ASupplier"];
        Response.Write("Name : " + ASupplier.SupplierName);
        Response.Write(" Email : " + ASupplier.Email);
        Response.Write(" Phone : " + ASupplier.Phone);
        Response.Write(" DateReg : " + ASupplier.DateReg);
        Response.Write(" Active : " + ASupplier.Active);

    }
}