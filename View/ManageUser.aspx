<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="PSDProject.View.ManageUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Button ID="logoutBtn" runat="server" Text="Log Out" OnClick="logoutBtn_Click"/>
            <asp:Button ID="manageProductBtn" runat="server" Text="Products" OnClick="manageProductBtn_Click"/>
            <br />
            <br />
            <br />

             <asp:GridView ID="UserView" runat="server" AutoGenerateColumns="false" OnRowEditing="UserView_RowEditing" OnRowDeleting="UserView_RowDeleting"
                >
                <Columns>
                    <asp:BoundField DataField="UserId" HeaderText="User ID"/>
                    <asp:BoundField DataField="Username" HeaderText="User Name"/>
                    <asp:BoundField DataField="Password" HeaderText="User Password"/>
                    <asp:CommandField HeaderText="Action" ShowDeleteButton="true" ShowEditButton="true"/>
                </Columns>
            </asp:GridView>
            <br />

            
            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="passTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
            <br />
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
