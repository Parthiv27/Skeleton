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
        ASupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        ASupplier.SupplierName = txtName.Text;
        ASupplier.Email = txtEmail.Text;
        ASupplier.Phone = txtPhone.Text;
        ASupplier.DateReg = Convert.ToDateTime(txtDateReg.Text);
        ASupplier.Active = Convert.ToBoolean(chkActive.Checked);

        Session["ASupplier"] = ASupplier;
        Response.Redirect("SupplierViewer.aspx");
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