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

        clsStock AnStock = new clsStock();

        string Producttype = txtProducttype.Text;
        string Size = txtSize.Text;
        string StockQuantity = txtStockQuantity.Text;
        string Daterestocked = txtDaterestocked.Text;
        string StockId = txtStockId.Text;
        string Restockneeded = chkRestockneeded.Text;
        string Discontinued = chkDiscontinued.Text;
        string Error = "";
        Error = AnStock.Valid(Producttype, Size, StockQuantity, Daterestocked);
        if (Error == "")
        {
            AnStock.Producttype = Producttype;
            AnStock.Size = Size;
            AnStock.StockQuantity = Convert.ToInt32(StockQuantity);
            AnStock.Daterestocked = Convert.ToDateTime(Daterestocked);
            AnStock.Restockneeded = chkRestockneeded.Checked;
            AnStock.Discontinued = chkDiscontinued.Checked;

            clsStockCollection StockList = new clsStockCollection();

            StockList.ThisStock = AnStock;

            StockList.Add();

            Response.Redirect("StockList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }








    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        Int32 StockId;

        Boolean Found = false;

        StockId = Convert.ToInt32(txtStockId.Text);

        Found = AnStock.Find(StockId);

        if (Found == true)
        {

            txtProducttype.Text = AnStock.Producttype;
            txtSize.Text = AnStock.Size;
            chkRestockneeded.Checked = AnStock.Restockneeded;
            txtDaterestocked.Text = AnStock.Daterestocked.ToString();
            chkDiscontinued .Checked = AnStock.Discontinued;
            txtStockQuantity.Text = AnStock.StockQuantity.ToString();








        }
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}
