<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 566px">

            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 531px; position: absolute; height: 18px; width: 70px"></asp:Label>

           
            <asp:ListBox ID="lstStockList" runat="server" Height="366px" Width="319px"></asp:ListBox>

            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 90px; top: 398px; position: absolute" Text="Edit" />

            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 175px; top: 399px; position: absolute" Text="Delete" />

            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 18px; top: 460px; position: absolute" Text="Enter product type"></asp:Label>
            <asp:TextBox ID="txtProducttype" runat="server" style="z-index: 1; left: 150px; top: 460px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 33px; top: 494px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 157px; top: 493px; position: absolute; height: 29px; width: 98px" Text="Clear Filter" />

        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 399px; position: absolute" Text="Add" />
    </form>
</body>
</html>
