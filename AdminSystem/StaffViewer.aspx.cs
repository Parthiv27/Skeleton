using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session obejct 
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the first name for this entry 
        Response.Write(AnStaff.StaffId);
        Response.Write(AnStaff.FirstName);
        Response.Write(AnStaff.LastName);
        Response.Write(AnStaff.Email);
        Response.Write(AnStaff.HireDate);
        Response.Write(AnStaff.Active);
        Response.Write(AnStaff.Salary);
    }
}