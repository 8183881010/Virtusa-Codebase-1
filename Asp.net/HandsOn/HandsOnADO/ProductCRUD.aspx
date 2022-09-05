<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductCRUD.aspx.cs" Inherits="HandsOnADO.ProductCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td>ProductId</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Pls Enter Id" ValidationGroup="VG"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>ProductName</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="Pls Enter Name" ValidationGroup="VG"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPrice" ErrorMessage="Pls Enter Price" ValidationGroup="VG"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Stock</td>
                    <td>
                        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtStock" ErrorMessage="Pls Enter Stock" ValidationGroup="VG"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Add_Product" Text="Add" ValidationGroup="VG" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Search_Product" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Delete_Product" Text="Delete" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Update_Product" Text="Update" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
