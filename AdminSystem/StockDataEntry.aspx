<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 396px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 25px; top: 43px; position: absolute" Text="StockID" width="79px"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 155px; top: 36px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 151px; top: 135px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblProducttype" runat="server" style="z-index: 1; left: 25px; top: 88px; position: absolute" Text="Product type" width="79px"></asp:Label>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 25px; top: 193px; position: absolute; width: 104px;" Text="Stock Quantity"></asp:Label>
        <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 25px; top: 135px; position: absolute" Text="Size"></asp:Label>
        <asp:Label ID="lblDaterestocked" runat="server" style="z-index: 1; left: 25px; top: 281px; position: absolute; right: 1033px;" Text="Daterestocked" width="79px"></asp:Label>
        <asp:Label ID="lblRestockneeded" runat="server" style="z-index: 1; left: 25px; top: 234px; position: absolute" Text="Restockneeded" width="79px"></asp:Label>
        <asp:TextBox ID="txtProducttype" runat="server" style="z-index: 1; left: 151px; top: 89px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 151px; top: 187px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtRestockneeded" runat="server" style="z-index: 1; left: 151px; top: 235px; position: absolute" width="168px"></asp:TextBox>
        <asp:TextBox ID="txtDaterestocked" runat="server" style="z-index: 1; left: 151px; top: 275px; position: absolute" width="168px"></asp:TextBox>
        <p>
        <asp:CheckBox ID="chkDiscontinued" runat="server" style="z-index: 1; left: 239px; top: 354px; position: absolute; width: 122px;" Text="Discontinued" />
            <asp:Label ID="lblDiscontinued" runat="server" style="z-index: 1; left: 24px; top: 316px; position: absolute; width: 96px" Text="Discontinued"></asp:Label>
            <asp:TextBox ID="txtDiscontinued" runat="server" style="z-index: 1; left: 131px; top: 314px; position: absolute; width: 183px"></asp:TextBox>
        </p>
        <asp:Button ID="lblOK" runat="server" style="z-index: 1; left: 29px; top: 354px; position: absolute" Text="OK" OnClick="lblOK_Click" />
        <asp:Button ID="lblCancel" runat="server" style="z-index: 1; left: 109px; top: 354px; position: absolute" Text="Cancel" OnClick="lblCancel_Click" />
    </form>
</body>
</html>