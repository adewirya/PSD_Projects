<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="PSDProject.View.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
            <br />
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
            <br />
            <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        </div>
    </form>
</body>
</html>
