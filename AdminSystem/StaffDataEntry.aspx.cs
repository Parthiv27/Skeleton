using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtActive { get; private set; }

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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key enterd by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //Find the record 
        Found = AnStaff.Find(StaffId);
        //if Found
        if (Found == true)
        {
            //display the value of properties in the form 
            txtStaffId.Text = AnStaff.StaffId.ToString();
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;    
            txtEmail.Text = AnStaff.Email;
            txtHireDate.Text = AnStaff.HireDate.ToString();
            chkActive.Checked = AnStaff.Active;
            txtSalary.Text = AnStaff.Salary.ToString();  

        }


    }
}

 