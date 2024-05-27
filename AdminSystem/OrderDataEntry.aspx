<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 530px">
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <p>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 116px; top: 51px; position: absolute; width: 133px; " height="22px"></asp:TextBox>
        </p>
        <p style="height: 25px">
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute; " Text="Order ID" height="19px" width="61px"></asp:Label>
            <asp:Label ID="lblStockItem" runat="server" height="19px" style="z-index: 1; left: 10px; top: 95px; position: absolute" Text="StockItem" width="61px"></asp:Label>
            <asp:TextBox ID="txtStockItem" runat="server" height="22px" style="z-index: 1; left: 114px; top: 94px; position: absolute; width: 130px"></asp:TextBox>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 149px; position: absolute; height: 23px; bottom: 504px; width: 61px;" Text="CustomerName"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerName" runat="server" OnTextChanged="CustomerName_TextChanged" style="z-index: 1; left: 108px; top: 143px; position: absolute; width: 129px; height: 22px;"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 199px; position: absolute; height: 19px; width: 61px;" Text="Price"></asp:Label>
      
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 115px; top: 194px; position: absolute; width: 130px;" height="22px"></asp:TextBox>
      
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkDispatched" runat="server" Checked="True" style="z-index: 1; left: 325px; top: 206px; position: absolute" Text="Dispatched" />
        <asp:Label ID="lblDispateDate" runat="server" style="z-index: 1; left: 16px; top: 253px; position: absolute; height: 22px;" Text="DispatchDate:" width="61px"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 303px; top: 454px; position: absolute"></asp:Label>
        <p style="height: 41px">
            <asp:TextBox ID="txtDispatchtDate" runat="server" height="22px" style="margin-left: 104px" width="128px"></asp:TextBox>
        </p>
        <p style="height: 44px">
            <asp:Label ID="lblDescription" runat="server" style="z-index: 1; left: 20px; top: 311px; position: absolute; width: 78px" Text="Description:"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 114px; top: 310px; position: absolute; width: 128px;"></asp:TextBox>
        &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 151px; top: 461px; position: absolute; height: 26px; width: 60px;" Text="Cancel" />
               <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 52px; top: 461px; position: absolute" Text="OK" height="26px" width="60px" />

        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>

    </form>
</body>

</html>
