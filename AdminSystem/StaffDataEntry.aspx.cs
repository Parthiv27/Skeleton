using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the StaffId
        AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the firstname
        AnStaff.FirstName = txtFirstName.Text;
        //capture the Lastname
        AnStaff.LastName = txtLastName.Text;
        //capture the Email
        AnStaff.Email = txtEmail.Text;
        //capture the HireDate
        AnStaff.HireDate = Convert.ToDateTime(DateTime.Now);
        //capture the Active Check box
        AnStaff.Active = chkActive.Checked;
        // Capture the Salary and convert it from string to decimal
        AnStaff.Salary = Convert.ToDecimal(txtSalary.Text);
        //store the firstname in the session object
        Session["AnStaff"] = AnStaff;
        //navigate  to the  view page 
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}

 