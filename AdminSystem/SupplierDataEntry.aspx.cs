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
        clsSupplier ASupplier = new clsSupplier();
        String SupplierID = txtSupplierID.Text;
        String SupplierName = txtName.Text;
        String Email = txtEmail.Text;
        String Phone = txtPhone.Text;
        String DateReg = txtDateReg.Text;
        bool Active = chkActive.Checked;


        string Error = "";
        Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
        if (Error == "")
        {
            ASupplier.SupplierName = SupplierName;
            ASupplier.Email = Email;
            ASupplier.Phone = Phone;
            ASupplier.DateReg = Convert.ToDateTime(DateReg);
            ASupplier.Active= Convert.ToBoolean(Active);

            Session["ASupplier"] = ASupplier;
            Response.Redirect("SupplierList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;

        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = ASupplier.Find(SupplierID);

        if (Found == true)
        {
            txtName.Text = ASupplier.SupplierName;
            txtEmail.Text = ASupplier.Email;
            txtPhone.Text = ASupplier.Phone;
            txtDateReg.Text = ASupplier.DateReg.ToString();
            chkActive.Checked = ASupplier.Active;
        }
    }
}