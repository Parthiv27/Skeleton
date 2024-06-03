<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CREPZ MAIN MENU</div>
        <p>
            <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 220px; top: 137px; position: absolute; height: 47px; width: 113px" Text="Stock" />
        </p>
        <asp:Button ID="btnCustomer" runat="server" height="47px" style="z-index: 1; left: 416px; top: 137px; position: absolute" Text="Customer" width="113px" />
        <asp:Button ID="btnStaff" runat="server" height="47px" style="z-index: 1; left: 625px; top: 138px; position: absolute" Text="Staff" width="113px" />
        <asp:Button ID="btnSupplier" runat="server" height="47px" style="z-index: 1; left: 292px; top: 229px; position: absolute" Text="Supplier" width="113px" />
        <asp:Button ID="btnOrder" runat="server" height="47px" style="z-index: 1; left: 523px; top: 228px; position: absolute" Text="Order" width="113px" />
    </form>
</body>
</html>
