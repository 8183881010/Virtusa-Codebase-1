<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnCustomGridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:TemplateField HeaderText="Name" ItemStyle-Width="150">
            <ItemTemplate>
                <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name") %>' />
            </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Price" ItemStyle-Width="150">
            <ItemTemplate>
                <asp:DropDownList ID="ddlPrice" runat="server">
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                </asp:DropDownList>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150px" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button Text="Select" runat="server" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        </div>
    </form>
</body>
</html>
