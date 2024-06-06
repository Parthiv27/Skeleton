<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderLoginPage" runat="server" style="z-index: 1; left: 27px; top: 49px; position: absolute" Text="Order login page "></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 180px; top: 176px; position: absolute" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 275px; top: 175px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TxtPassword" runat="server" style="z-index: 1; left: 278px; top: 220px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 183px; top: 224px; position: absolute; width: 62px" Text="Password:"></asp:Label>
        <asp:Label ID="LblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 456px; top: 198px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 217px; top: 288px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 329px; top: 284px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
