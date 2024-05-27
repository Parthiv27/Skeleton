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
            DisplayStocks();
        }

    }

    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();

        lstStockList.DataSource = Stocks.StockList;

        lstStockList.DataValueField = "StockId";

        lstStockList.DataTextField = "Producttype";

        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockId"] = -1;

        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockId;

        if (lstStockList.SelectedIndex != -1)
        {
            StockId = Convert.ToInt32(lstStockList.SelectedValue);

            Session["StockId"] = StockId;

            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockId;

        if (lstStockList.SelectedIndex != -1)
        {
            StockId = Convert.ToInt32(lstStockList.SelectedValue);

            Session["StockId"] = StockId;

            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";

        }
    }
}