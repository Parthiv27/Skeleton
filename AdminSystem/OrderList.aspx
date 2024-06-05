<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="251px" Width="374px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="38px" height="25px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 70px; top: 305px; position: absolute; width: 38px; height: 25px" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 55px; position: absolute; top: 357px" Text="[lblError]"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; top: 304px; position: absolute; height: 25px; width: 49px; left: 133px" Text="Delete" />
        </p>
    </form>
</body>
</html>