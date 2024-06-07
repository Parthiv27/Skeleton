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
        if (IsPostBack == false)
        {
            DisplaySupplier();
        }
        clsSupplierUser AnUser = new clsSupplierUser();
        AnUser = (clsSupplierUser)Session["AnUser"];
        Response.Write("Logged in as : " + AnUser.Username);
    }

    void DisplaySupplier()
    {
        clsSupplierCollection AllSupplier = new clsSupplierCollection();
        lstSupplierList.DataSource = AllSupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Select Supplier to Edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Select Supplier to Delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierEmail(txtSupplierEmail.Text);
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void lblClearFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierEmail("");
        txtSupplierEmail.Text = "";
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void btnTeammainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}