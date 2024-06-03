<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDepartmentLogin.aspx.cs" Inherits="StaffDepartmentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 10px; top: 68px; position: absolute" Text="Staff Department Login Page"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 182px; top: 157px; position: absolute; height: 23px; width: 132px; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 184px; top: 229px; position: absolute; height: 23px; width: 132px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 52px; top: 161px; position: absolute" Text="UserName:"></asp:Label>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 59px; top: 236px; position: absolute" Text="Password:"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 427px; top: 228px; position: absolute; height: 24px" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 181px; top: 304px; position: absolute; height: 28px; width: 61px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 271px; top: 306px; position: absolute; height: 28px; width: 61px" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
