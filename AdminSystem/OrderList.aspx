<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="251px" Width="374px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 73px; top: 305px; position: absolute; width: 38px; height: 25px; right: 1728px;" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 54px; position: absolute; top: 508px; height: 23px;" Text="[lblError]"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; top: 306px; position: absolute; height: 25px; width: 49px; left: 135px" Text="Delete" />
        </p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="z-index: 1; left: 9px; top: 307px; position: absolute; height: 25px; width: 39px; right: 1791px" />
        <asp:Label ID="lblEnterCustomerName" runat="server" style="z-index: 1; left: 38px; top: 373px; position: absolute; right: 1637px; height: 21px" Text="Enter a Customer Name:"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; top: 373px; position: absolute; left: 272px; height: 17px; width: 124px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 26px; top: 435px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 188px; top: 432px; position: absolute; height: 26px" Text="Clear Filter" width="100px" />
    </form>
</body>
</html>