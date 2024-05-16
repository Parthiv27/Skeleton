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
        <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 25px; top: 43px; position: absolute" Text="StockID" width="99px" height="19px"></asp:Label>
        <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 131px; top: 36px; position: absolute" height="22px" width="183px"></asp:TextBox>
        <asp:TextBox ID="txtSize" runat="server" style="z-index: 1; left: 131px; top: 135px; position: absolute" width="183px" height="22px"></asp:TextBox>
        <asp:Label ID="lblProducttype" runat="server" style="z-index: 1; left: 25px; top: 88px; position: absolute" Text="Product type" width="99px" height="19px"></asp:Label>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 25px; top: 193px; position: absolute; width: 99px;" Text="Stock Quantity" height="19px"></asp:Label>
        <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 25px; top: 135px; position: absolute" Text="Size" height="19px" width="99px"></asp:Label>
        <asp:Label ID="lblDaterestocked" runat="server" style="z-index: 1; left: 25px; top: 235px; position: absolute; height: 30px;" Text="Daterestocked" width="99px"></asp:Label>
        <asp:TextBox ID="txtProducttype" runat="server" style="z-index: 1; left: 131px; top: 89px; position: absolute" width="183px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtStockQuantity" runat="server" style="z-index: 1; left: 131px; top: 187px; position: absolute" width="183px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtDaterestocked" runat="server" style="z-index: 1; left: 131px; top: 233px; position: absolute; height: 23px;" width="183px"></asp:TextBox>
        <p>
        <asp:CheckBox ID="chkDiscontinued" runat="server" style="z-index: 1; left: 239px; top: 354px; position: absolute; width: 122px;" Text="Discontinued" />
            <asp:CheckBox ID="chkRestockneeded" runat="server" style="z-index: 1; left: 356px; top: 353px; position: absolute" Text="Restockneeded" />
        </p>
        
         <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 29px; top: 354px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 109px; top: 354px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 419px; top: 38px; position: absolute" Text="Find" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 285px; position: absolute"></asp:Label>
    </form>
</body>
</html>