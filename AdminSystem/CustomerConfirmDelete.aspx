<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 126px; top: 182px; position: absolute; width: 71px;" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 217px; top: 182px; position: absolute; width: 66px;" Text="No" />
            <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 91px; top: 139px; position: absolute; width: 272px" Text="Are you sure you want to delete this record?"></asp:Label>        
        </div>            
    </form>
</body>
</html>
