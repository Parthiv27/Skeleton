<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 10px; top: 55px; position: absolute; bottom: 490px" Text="SupplierID" width="114px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 130px; top: 55px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnfind" runat="server" style="z-index: 1; left: 350px; top: 55px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 99px; position: absolute; right: 848px" Text="Full Name" width="114px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 130px; top: 99px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute" Text="Email" width="114px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 130px; top: 143px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 10px; top: 187px; position: absolute" Text="Phone" width="114px"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 130px; top: 187px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDateReg" runat="server" style="z-index: 1; left: 10px; top: 231px; position: absolute" Text="DateReg" width="114px"></asp:Label>
            <asp:TextBox ID="txtDateReg" runat="server" style="z-index: 1; left: 130px; top: 231px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 130px; top: 273px; position: absolute" />
            <br />
            <asp:Button ID="btnTeamMainMenu" runat="server" OnClick="btnTeamMainMenu_Click" style="z-index: 1; left: 310px; top: 351px; position: absolute" Text="Main Menu" />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 307px; position: absolute"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 354px; position: absolute" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 182px; top: 352px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
