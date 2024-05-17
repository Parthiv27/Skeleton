<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 13px; top: 42px; position: absolute" Text="CustomerID"></asp:Label>
        <p style="height: 0px">
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 207px; top: 36px; position: absolute; height: 33px; width: 171px"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 205px; top: 112px; position: absolute; height: 32px; width: 174px"></asp:TextBox>
        <p>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 13px; top: 116px; position: absolute" Text="First Name"></asp:Label>
        </p>
        <asp:Label ID="lblSurName" runat="server" style="z-index: 1; left: 13px; top: 177px; position: absolute" Text="Sur Name"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 203px; top: 171px; position: absolute; height: 32px; bottom: 560px"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 12px; top: 243px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 202px; top: 237px; position: absolute; width: 247px; height: 33px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 12px; top: 299px; position: absolute; width: 87px" Text="Address"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 203px; top: 292px; position: absolute; height: 28px; width: 469px"></asp:TextBox>
        <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; left: 12px; top: 349px; position: absolute" Text="Date Joined"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 202px; top: 345px; position: absolute; height: 30px; width: 193px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 197px; top: 411px; position: absolute" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 463px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 203px; top: 534px; position: absolute; width: 61px" Text="OK" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 296px; top: 534px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
