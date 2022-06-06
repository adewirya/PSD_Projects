<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="PSDProject.View.UpdateCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="prodLbl" runat="server" Text="ProductName"></asp:Label>
            <br />
            <asp:Label ID="descLbl" runat="server" Text="ProductDesc"></asp:Label>
            <br />
            <asp:Label ID="priceLbl" runat="server" Text="ProductPrice"></asp:Label>
            <br />
            
            <asp:Label ID="quantityLbl" runat="server" Text="Quantity"></asp:Label>
            <br />
            <asp:TextBox ID="qtyTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />
        </div>
    </form>
</body>
</html>
