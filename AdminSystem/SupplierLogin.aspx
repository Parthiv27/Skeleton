<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="SupplierLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lblusername" runat="server" style="z-index: 1; left: 39px; top: 117px; position: absolute" Text="Username: "></asp:Label>
    <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 41px; top: 171px; position: absolute" Text="Password: "></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 169px; top: 120px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 166px; top: 168px; position: absolute" TextMode="Password"></asp:TextBox>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 396px; top: 168px; position: absolute"></asp:Label>
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 101px; top: 237px; position: absolute" Text="Login" />
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 224px; top: 239px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
    <asp:Label ID="lebelLoginPage" runat="server" style="z-index: 1; left: 100px; top: 37px; position: absolute" Text="Suppliers Login Page"></asp:Label>
        </p>
    </form>
</body>
</html>
