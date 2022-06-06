<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageCart.aspx.cs" Inherits="PSDProject.View.ManageCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="logoutBtn" runat="server" Text="Log Out" OnClick="logoutBtn_Click" />
            <asp:Button ID="homeBtn" runat="server" Text="Home" OnClick="homeBtn_Click" />
            <br />
            <br />

            <asp:GridView ID="CartView" runat="server" AutoGenerateColumns="false" OnRowEditing="CartView_RowEditing" OnRowDeleting="CartView_RowDeleting"
                >
                <Columns>
                    <asp:BoundField DataField="CartId" HeaderText="Cart Id"/>
                    <asp:BoundField DataField="ProductId" HeaderText="Product Id"/>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity"/>
                    <asp:CommandField HeaderText="Action" ShowDeleteButton="true" ShowEditButton="true"/>
                </Columns>
            </asp:GridView>

            <br />
            <asp:Button ID="checkOutBtn" runat="server" Text="Check Out" OnClick="checkOutBtn_Click"/>

        </div>
    </form>
</body>
</html>
