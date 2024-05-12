<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 530px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 89px; top: 54px; position: absolute; width: 129px; right: 208px;"></asp:TextBox>
        </p>
        <p style="height: 25px">
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; right: 349px" Text="Order ID" height="19px" width="61px"></asp:Label>
            <asp:Label ID="lblShoeID" runat="server" height="19px" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Shoe " width="61px"></asp:Label>
            <asp:TextBox ID="txtShoe" runat="server" height="22px" style="z-index: 1; left: 91px; top: 91px; position: absolute; width: 129px"></asp:TextBox>
            <asp:Label ID="lblFirstnameID" runat="server" style="z-index: 1; left: 10px; top: 134px; position: absolute; height: 19px; bottom: 523px" Text="Firstname" width="61px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtFirstname" runat="server" height="22px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 90px; top: 135px; position: absolute; width: 129px"></asp:TextBox>
        </p>
        <asp:Label ID="lblSurnameID" runat="server" style="z-index: 1; left: 12px; position: absolute; height: 19px; width: 61px; right: 325px" Text="Surname"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server" height="22px" style="z-index: 1; left: 89px; top: 174px; position: absolute" width="129px"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 9px; top: 210px; position: absolute" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" height="22px" style="z-index: 1; left: 88px; top: 206px; position: absolute" width="129px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="DispatchedID" runat="server" Checked="True" style="z-index: 1; left: 95px; top: 247px; position: absolute" Text="Dispatched" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 294px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 53px; top: 361px; position: absolute" Text="OK" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 130px; top: 363px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
