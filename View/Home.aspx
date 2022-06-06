<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSDProject.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="logoutBtn" runat="server" Text="Log Out" OnClick="logoutBtn_Click" />
            <asp:Button ID="cartBtn" runat="server" Text="Carts" OnClick="cartBtn_Click" />
            <br />
            <br />
            <br />

           <asp:GridView ID="ProductView" runat="server" AutoGenerateColumns="false"
                >
                <Columns>
                    <asp:BoundField DataField="ProductId" HeaderText="Product Id"/>
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
                    <asp:BoundField DataField="ProductDescription" HeaderText="Product Description"/>
                    <asp:BoundField DataField="ProductPrice" HeaderText="Product Price"/>
                </Columns>
            </asp:GridView>

            <br />


            <asp:Label ID="Label4" runat="server" Text="ProductId"></asp:Label>
            <br />
            <asp:TextBox ID="productIdTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Quantity"></asp:Label>
            <br />
            <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addCartBtn" runat="server" Text="AddToCart" OnClick="addCartBtn_Click" />
            <br />
        </div>
    </form>
</body>
</html>
