<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 216px; top: 385px; position: absolute; height: 29px" Text="Delete" width="68px" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 46px; top: 41px; position: absolute; height: 323px; width: 438px;"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 53px; top: 385px; position: absolute; height: 29px; width: 68px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 132px; top: 386px; position: absolute; height: 29px; width: 68px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 61px; top: 547px; position: absolute"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 56px; top: 445px; position: absolute" Text="Enter a First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 187px; top: 435px; position: absolute; height: 28px; width: 194px"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 62px; top: 490px; position: absolute; height: 29px; width: 120px; right: 1208px" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 203px; top: 492px; position: absolute; height: 29px;" Text="Clear Filter" />
            <asp:Button ID="btnReturntoMainMenu" runat="server" OnClick="btnReturntoMainMenu_Click" style="z-index: 1; left: 314px; top: 491px; position: absolute; height: 30px;" Text="Return to Main Menu" />
        </div>
    </form>
    </body>
</html>

