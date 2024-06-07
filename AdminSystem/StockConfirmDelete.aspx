<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 80px">
        Are you sure you want to delete this record?</p>
    <p style="margin-left: 80px">
        &nbsp;</p>
    <form id="form1" runat="server">
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 278px; top: 211px; position: absolute; width: 40px" Text="No" />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 157px; top: 211px; position: absolute" Text="Yes" />
        <div>
        </div>
    </form>
</body>
</html>
