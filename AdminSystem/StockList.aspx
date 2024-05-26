<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 444px; position: absolute; height: 18px; width: 70px"></asp:Label>

            <asp:ListBox ID="lstStockList" runat="server" Height="366px" Width="319px"></asp:ListBox>

            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 90px; top: 398px; position: absolute" Text="Edit" />

        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 399px; position: absolute" Text="Add" />
    </form>
</body>
</html>
