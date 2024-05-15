<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 353px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 25px; top: 43px; position: absolute" Text="StaffID" width="79px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 155px; top: 36px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 151px; top: 135px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 25px; top: 88px; position: absolute" Text="FirstName" width="79px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 202px; top: 322px; position: absolute; width: 92px;" Text="Active" />
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 25px; top: 193px; position: absolute" Text="Email" width="79px"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 25px; top: 135px; position: absolute" Text="LastName"></asp:Label>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 25px; top: 281px; position: absolute" Text="Salary" width="79px"></asp:Label>
        <asp:Label ID="lblHireDate" runat="server" style="z-index: 1; left: 25px; top: 234px; position: absolute" Text="HireDate" width="79px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 151px; top: 89px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 151px; top: 187px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtHireDate" runat="server" style="z-index: 1; left: 151px; top: 235px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 151px; top: 275px; position: absolute" width="168px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 382px; position: absolute; bottom: 213px;" width="77px"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 27px; top: 428px; position: absolute" Text="OK" width="77px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 145px; top: 428px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
