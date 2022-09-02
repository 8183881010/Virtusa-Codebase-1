<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="MyFirstWebAPP.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text=" GO" />
            <br />
            Enter Date
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
            <input type="date" />
        </div>
    </form>
</body>
</html>
