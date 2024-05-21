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
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 108px; top: 54px; position: absolute; width: 129px; " height="22px"></asp:TextBox>
        </p>
        <p style="height: 25px">
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; " Text="Order ID" height="19px" width="61px"></asp:Label>
            <asp:Label ID="lblStockItem" runat="server" height="19px" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="StockItem" width="61px"></asp:Label>
            <asp:TextBox ID="txtStockItem" runat="server" height="22px" style="z-index: 1; left: 108px; top: 91px; position: absolute; width: 129px"></asp:TextBox>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 11px; top: 135px; position: absolute; height: 19px; bottom: 720px; width: 61px;" Text="CustomerName"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerName" runat="server" height="22px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 108px; top: 133px; position: absolute; width: 129px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 171px; position: absolute; height: 19px; width: 61px;" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" height="22px" style="z-index: 1; left: 108px; top: 175px; position: absolute" width="129px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="DispatchedID" runat="server" Checked="True" style="z-index: 1; left: 404px; top: 302px; position: absolute" Text="Dispatched" />
        <asp:Label ID="lblDispateDate" runat="server" height="19px" style="z-index: 1; left: 10px; top: 211px; position: absolute" Text="DispatchDate:" width="61px"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 303px; top: 454px; position: absolute"></asp:Label>
        <p style="height: 126px">
            <asp:Calendar ID="clndrDispatchDate" runat="server" style="z-index: 1; left: 102px; top: 216px; position: absolute; height: 104px; width: 216px"></asp:Calendar>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 151px; top: 461px; position: absolute; height: 26px; width: 60px;" Text="Cancel" />
               <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 52px; top: 461px; position: absolute" Text="OK" height="26px" width="60px" />

        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>

    </form>
</body>

</html>
