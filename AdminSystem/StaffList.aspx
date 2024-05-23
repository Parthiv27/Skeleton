<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 46px; top: 41px; position: absolute; height: 377px; width: 495px; margin-left: 0px;" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 64px; top: 435px; position: absolute; height: 39px; width: 55px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 149px; top: 434px; position: absolute; height: 37px; width: 56px" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 65px; top: 518px; position: absolute" Text="lblError"></asp:Label>
    </form>
    </body>
</html>
