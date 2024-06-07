using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
        if (IsPostBack == false)
        {
            if (StockId != -1)
            {
                DisplayStock();
            }
        }
    }





    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStock AnStock = new clsStock();

        string Producttype = txtProducttype.Text;
        string Size = txtSize.Text;
        string StockQuantity = txtStockQuantity.Text;
        string Daterestocked = txtDaterestocked.Text;        
        string Restockneeded = chkRestockneeded.Text;
        string Discontinued = chkDiscontinued.Text;
        string Error = "";
        Error = AnStock.Valid(Producttype, Size, StockQuantity, Daterestocked);
        if (Error == "")
        {
            AnStock.StockId = StockId;
            AnStock.Producttype = Producttype;
            AnStock.Size = Size;
            AnStock.StockQuantity = Convert.ToInt32(StockQuantity);
            AnStock.Daterestocked = Convert.ToDateTime(Daterestocked);
            AnStock.Restockneeded = chkRestockneeded.Checked;
            AnStock.Discontinued = chkDiscontinued.Checked;

            clsStockCollection StockList = new clsStockCollection();

            if (StockId == 1)
            {
                StockList.ThisStock = AnStock;

                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(StockId);

                StockList.ThisStock = AnStock;

                StockList.Update();
            }           

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


    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();

        Stock.ThisStock.Find(StockId);

        txtStockId.Text = Stock.ThisStock.StockId.ToString();
        chkDiscontinued.Checked = Stock.ThisStock.Discontinued;
        chkRestockneeded.Checked = Stock.ThisStock.Restockneeded;
        txtProducttype.Text = Stock.ThisStock.Producttype.ToString();
        txtSize.Text = Stock.ThisStock.Size.ToString();
        txtDaterestocked.Text = Stock.ThisStock.Daterestocked.ToString();
        txtStockQuantity.Text = Stock.ThisStock.StockQuantity.ToString();

    }



    protected void btnreturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
