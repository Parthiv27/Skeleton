﻿using System;
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
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        // Create an instance of the class we want to create 
        clsStaffCollection Staff = new clsStaffCollection();
        // Set the data source to the list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        // Set the data value field of the primary key
        lstStaffList.DataValueField = "StaffId";
        // Set the data field to display
        lstStaffList.DataTextField = "FirstName";
        // Bind the data to the list 
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store  -1 into the session object to indicate this new record 
        Session["StaffId"] = -1;
        //redirect to the data enrty page
        Response.Redirect("StaffDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of record to be edited
        Int32 StaffId;
        //if a recod has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primarykey value of the ecord to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session obejct
            Session["StaffId"] = StaffId;
            //redirect to edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else  //if no record has been selected
        {
            lblError.Text = "Please Select a record from the list to edit";

        }
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}