<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 268px; top: 180px; position: absolute; height: 29px; width: 42px;" Text="No" OnClick="btnNo_Click" />
            <asp:Label ID="lbltext" runat="server" style="z-index: 1; left: 96px; top: 126px; position: absolute; width: 279px" Text="You want to delete this supplier"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 131px; top: 180px; position: absolute" Text="Yes" />
            </p>
    </form>
</body>
</html>
