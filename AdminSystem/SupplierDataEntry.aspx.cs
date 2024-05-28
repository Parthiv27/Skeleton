using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            if (SupplierID != -1)
            {
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        clsSupplierCollection SuppliersAll = new clsSupplierCollection();
        SuppliersAll.ThisSupplier.Find(SupplierID);
        txtSupplierID.Text = SuppliersAll.ThisSupplier.SupplierID.ToString();
        txtName.Text = SuppliersAll.ThisSupplier.SupplierName.ToString();
        txtEmail.Text = SuppliersAll.ThisSupplier.Email.ToString();
        txtPhone.Text = SuppliersAll.ThisSupplier.Phone.ToString();
        txtDateReg.Text = SuppliersAll.ThisSupplier.DateReg.ToString();
        chkActive.Checked = SuppliersAll.ThisSupplier.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        String SupplierName = txtName.Text;
        String Email = txtEmail.Text;
        String Phone = txtPhone.Text;
        String DateReg = txtDateReg.Text;
        bool Active = chkActive.Checked;


        string Error = "";
        Error = ASupplier.Valid(SupplierName, Email, Phone, DateReg, Active);
        if (Error == "")
        {
            ASupplier.SupplierID = SupplierID;
            ASupplier.SupplierName = SupplierName;
            ASupplier.Email = Email;
            ASupplier.Phone = Phone;
            ASupplier.DateReg = Convert.ToDateTime(DateReg);
            ASupplier.Active= Convert.ToBoolean(Active);

            clsSupplierCollection SupplierList = new clsSupplierCollection();

            if (SupplierID == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }

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