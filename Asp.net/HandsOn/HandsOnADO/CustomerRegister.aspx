<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegister.aspx.cs" Inherits="HandsOnADO.CustomerRegister" %>

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
                    <td>CustomerId *</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Pls Enter CustomerId"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>CustomerName *</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="Pls Enter Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rblGendar" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>FeMale</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAge" ErrorMessage="Invalid Age" MaximumValue="40" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Mobile</td>
                    <td>
                        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMobile" ErrorMessage="Invalid Mobile No" ValidationExpression="[6789][0-9]{9}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Country</td>
                    <td>
                        <asp:DropDownList ID="ddlCountry" runat="server">
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>US</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                            <asp:ListItem>China</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Login Details</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Username *</td>
                    <td>
                        <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUname" ErrorMessage="Pls Enter Username"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password *</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPwd" ErrorMessage="Pls Enter Password"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPwd" ErrorMessage="Invalid Password" ValidationExpression="[0-9a-zA-Z]{6,8}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>ConfirmPassword </td>
                    <td>
                        <asp:TextBox ID="txtCpwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtCpwd" ErrorMessage="Password Mismatch"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Register" Text="Submit" />
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
