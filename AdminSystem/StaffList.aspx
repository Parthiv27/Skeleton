<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 214px; top: 392px; position: absolute; height: 29px" Text="Delete" />
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 46px; top: 41px; position: absolute; height: 323px; width: 438px; margin-left: 0px;" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 52px; top: 387px; position: absolute; height: 29px; width: 68px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 132px; top: 389px; position: absolute; height: 29px; width: 68px" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 61px; top: 547px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 56px; top: 445px; position: absolute" Text="Enter a First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 240px; top: 444px; position: absolute; height: 28px; width: 194px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 68px; top: 495px; position: absolute; height: 29px; width: 120px; right: 1155px" Text="Apply Filter" />
        <p>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 246px; top: 495px; position: absolute" Text="Clear Filter" />
        </p>
        <asp:Button ID="btnReturntoMainMenu" runat="server" OnClick="btnReturntoMainMenu_Click" style="z-index: 1; left: 451px; top: 499px; position: absolute" Text="Return to Main Menu" />
    </form>
    </body>
</html>
