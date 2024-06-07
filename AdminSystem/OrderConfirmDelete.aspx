<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 272px; top: 123px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 282px; top: 180px; position: absolute; bottom: 657px; width: 58px" Text="Yes" />
        <p>
            <asp:Button ID="BtnNo" runat="server" height="26px" OnClick="BtnNo_Click" style="z-index: 1; left: 441px; top: 179px; position: absolute" Text="No" width="58px" />
        </p>
    </form>
</body>
</html>
