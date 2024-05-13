<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 336px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 19px; top: 43px; position: absolute" Text="StaffID"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 155px; top: 36px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 156px; top: 135px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 28px; top: 88px; position: absolute" Text="FirstName"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 203px; top: 322px; position: absolute" Text="Active" />
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 37px; top: 193px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 25px; top: 135px; position: absolute" Text="LastName"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 22px; top: 281px; position: absolute" Text="Salary"></asp:Label>
        <asp:Label ID="lblHireDate" runat="server" style="z-index: 1; left: 22px; top: 234px; position: absolute" Text="HireDate"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 158px; top: 89px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 154px; top: 187px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHireDate" runat="server" style="z-index: 1; left: 153px; top: 235px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 152px; top: 275px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 371px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 37px; top: 406px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 110px; top: 408px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
