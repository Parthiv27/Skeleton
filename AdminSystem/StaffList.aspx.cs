using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (!IsPostBack)
        {
            // Update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // Create an instance of the class we want to create 
        clsStaffCollection Staff = new clsStaffCollection();
        // Set the data source to the list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        // Set the data value field of the primary key
        lstStaffList.DataValueField = "StaffId";
        // Set the data field to display
        lstStaffList.DataTextField = "FirstName";
        // Bind the data to the list 
        lstStaffList.DataBind();
    }
}