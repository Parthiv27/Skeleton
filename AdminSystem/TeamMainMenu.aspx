<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <p>
            <asp:Label ID="Label1" runat="server" Font-Size="40pt" style="z-index: 1; left: 181px; top: 67px; position: absolute" Text="Main Menu"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        


        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CREPZ MAIN MENU</div>
        <p>
            <asp:Button ID="btnStock" runat="server" OnClick="btnStock_Click" style="z-index: 1; left: 220px; top: 137px; position: absolute; height: 47px; width: 113px" Text="Stock" />
        </p>
        <asp:Button ID="btnCustomer" runat="server" height="47px" style="z-index: 1; left: 416px; top: 154px; position: absolute" Text="Customer" width="113px" OnClick="btnCustomer_Click" />
        <asp:Button ID="btnStaff" runat="server" height="47px" style="z-index: 1; left: 625px; top: 138px; position: absolute" Text="Staff" width="113px" OnClick="btnStaff_Click" />
        <asp:Button ID="btnSupplier" runat="server" height="47px" style="z-index: 1; left: 292px; top: 229px; position: absolute" Text="Supplier" width="113px" OnClick="btnSupplier_Click" />
        <asp:Button ID="btnOrder" runat="server" Height="47px" Style="z-index: 1; left: 523px; top: 228px; position: absolute" Text="Order" Width="113px" OnClick="btnOrder_Click" />
    </form>
</body>
</html>
