<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="PSDProject.View.ManageProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="logoutBtn" runat="server" Text="Log Out" OnClick="logoutBtn_Click1"   />
            <asp:Button ID="manageUserBtn" runat="server" Text="Users" OnClick="manageUserBtn_Click"/>
            <br />
            <br />
            <br />

             <asp:GridView ID="ProductView" runat="server" AutoGenerateColumns="false" OnRowEditing="ProductView_RowEditing" OnRowDeleting="ProductView_RowDeleting"
                >
                <Columns>
                    <asp:BoundField DataField="ProductId" HeaderText="Product Id"/>
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
                    <asp:BoundField DataField="ProductDescription" HeaderText="Product Description"/>
                    <asp:BoundField DataField="ProductPrice" HeaderText="Product Price"/>
                    <asp:CommandField HeaderText="Action" ShowDeleteButton="true" ShowEditButton="true"/>
                </Columns>
            </asp:GridView>
            <br />

            
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Description"></asp:Label>
            <br />
            <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
            <br />
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
