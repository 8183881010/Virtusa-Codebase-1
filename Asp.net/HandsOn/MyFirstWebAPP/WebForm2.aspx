<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MyFirstWebAPP.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select Hobies:<br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Cricket" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Football" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Tennis" />
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Chess" />
            <br />
            Select Account<br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="account" Text="Savings" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="account" Text="Current" />
        </div>
    </form>
</body>
</html>
