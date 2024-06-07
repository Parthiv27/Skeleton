<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Customer Login Page
                <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 75px; top: 206px; position: absolute; height: 24px; width: 100px" Text="Username"></asp:Label>
                <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 75px; top: 249px; position: absolute; height: 28px; width: 98px" Text="Password"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 190px; top: 205px; position: absolute; width: 174px"></asp:TextBox>
                <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 190px; top: 247px; position: absolute; height: 22px; width: 171px" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 445px; top: 243px; position: absolute; width: 69px; height: 18px"></asp:Label>      
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 265px; top: 313px; position: absolute; height: 42px; width: 82px" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 125px; top: 318px; position: absolute; height: 36px; width: 75px" Text="Login" />
        </div>
    </form>
</body>
</html>
