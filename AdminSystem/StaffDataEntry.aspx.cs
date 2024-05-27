using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //public object txtActive { get; private set; }
    //public object salary { get; private set; }
    //public bool active { get; private set; }
    //public DateTime hireDate { get; private set; }
    //public string email { get; private set; }
    //public string firstName { get; private set; }
    //public string lastName { get; private set; }

    //variable to store the primary key with page level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    { 
        //get the number of staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
               // If StaffId is not -1, display the staff record
                if (StaffId != -1)
                {
                    DisplayStaff();
                }    
        }
    }

     void DisplayStaff()
    {
        // Create an instance of the staff collection
        clsStaffCollection StaffDataEntry = new clsStaffCollection();

        // Find the record to update
        if (StaffDataEntry.ThisStaff.Find(StaffId))
        {
            // Display the data in the text boxes
            txtStaffId.Text = StaffDataEntry.ThisStaff.StaffId.ToString();
            txtFirstName.Text = StaffDataEntry.ThisStaff.FirstName.ToString();
            txtLastName.Text = StaffDataEntry.ThisStaff.LastName.ToString();
            txtEmail.Text = StaffDataEntry.ThisStaff.Email.ToString();
            txtHireDate.Text = StaffDataEntry.ThisStaff.HireDate.ToString();
            chkActive.Checked = StaffDataEntry.ThisStaff.Active;
            txtSalary.Text = StaffDataEntry.ThisStaff.Salary.ToString();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();


        //capture the firstname
        string firstName = txtFirstName.Text;

        //capture the Lastname
        string lastName = txtLastName.Text;

        //capture the Email
        string email = txtEmail.Text;

        //capture the HireDate
        string hireDate = txtHireDate.Text; // Assume you have a field named txtHireDate for hire date input

        //capture the Active Check box
        bool active = chkActive.Checked;

        //capture the Salary
        string salary = txtSalary.Text;

        //variable to store any error message
        string Error = "";

        //Validate  data
        Error = AnStaff.Valid(firstName, lastName, email, hireDate, salary);

        if (Error == "")
        {
            //assign the values to the AnStaff object
            AnStaff.StaffId = StaffId; // Dont miss this bit
            AnStaff.FirstName = firstName;
            AnStaff.LastName = lastName;
            AnStaff.Email = email;
            AnStaff.HireDate = Convert.ToDateTime(hireDate);
            AnStaff.Active = chkActive.Checked;
            AnStaff.Salary = Convert.ToDecimal(salary);
            //create a new instance of stafff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //new record 
            if (StaffId == -1)

            {  //set the thisstaff property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
        else
        {
            // Find record to update
            StaffList.ThisStaff.Find(StaffId);
            StaffList.ThisStaff = AnStaff;
            StaffList.Update();
        }
        //navigate to the view page
        Response.Redirect("StaffList.aspx");

        //display the error message
        lblError.Text = Error;
        }
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
