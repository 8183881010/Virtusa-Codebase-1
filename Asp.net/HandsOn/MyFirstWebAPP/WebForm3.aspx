<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="MyFirstWebAPP.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>US</asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Cricket</asp:ListItem>
            <asp:ListItem>Football</asp:ListItem>
            <asp:ListItem>Tennis</asp:ListItem>
        </asp:CheckBoxList>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>English</asp:ListItem>
            <asp:ListItem>Hindi</asp:ListItem>
            <asp:ListItem>Malayalam</asp:ListItem>
            <asp:ListItem>Telugu</asp:ListItem>
            <asp:ListItem>Tamil</asp:ListItem>
        </asp:ListBox>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Saving</asp:ListItem>
            <asp:ListItem>Current</asp:ListItem>
            <asp:ListItem>Joint</asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>
