<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListViewDemo.aspx.cs" Inherits="HandsOnDataBindControlsDemo.ListViewDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VirtusaDBConnectionString %>" DeleteCommand="DELETE FROM [product] WHERE [pid] = @pid" InsertCommand="INSERT INTO [product] ([pid], [pname], [price], [stock]) VALUES (@pid, @pname, @price, @stock)" SelectCommand="SELECT * FROM [product]" UpdateCommand="UPDATE [product] SET [pname] = @pname, [price] = @price, [stock] = @stock WHERE [pid] = @pid">
        <DeleteParameters>
            <asp:Parameter Name="pid" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="pid" Type="Int32" />
            <asp:Parameter Name="pname" Type="String" />
            <asp:Parameter Name="price" Type="Int32" />
            <asp:Parameter Name="stock" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="pname" Type="String" />
            <asp:Parameter Name="price" Type="Int32" />
            <asp:Parameter Name="stock" Type="Int32" />
            <asp:Parameter Name="pid" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="pid" DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="pidLabel" runat="server" Text='<%# Eval("pid") %>' />
                </td>
                <td>
                    <asp:Label ID="pnameLabel" runat="server" Text='<%# Eval("pname") %>' />
                </td>
                <td>
                    <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                </td>
                <td>
                    <asp:Label ID="stockLabel" runat="server" Text='<%# Eval("stock") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:Label ID="pidLabel1" runat="server" Text='<%# Eval("pid") %>' />
                </td>
                <td>
                    <asp:TextBox ID="pnameTextBox" runat="server" Text='<%# Bind("pname") %>' />
                </td>
                <td>
                    <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                </td>
                <td>
                    <asp:TextBox ID="stockTextBox" runat="server" Text='<%# Bind("stock") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="pidTextBox" runat="server" Text='<%# Bind("pid") %>' />
                </td>
                <td>
                    <asp:TextBox ID="pnameTextBox" runat="server" Text='<%# Bind("pname") %>' />
                </td>
                <td>
                    <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                </td>
                <td>
                    <asp:TextBox ID="stockTextBox" runat="server" Text='<%# Bind("stock") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="pidLabel" runat="server" Text='<%# Eval("pid") %>' />
                </td>
                <td>
                    <asp:Label ID="pnameLabel" runat="server" Text='<%# Eval("pname") %>' />
                </td>
                <td>
                    <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                </td>
                <td>
                    <asp:Label ID="stockLabel" runat="server" Text='<%# Eval("stock") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server"></th>
                                <th runat="server">pid</th>
                                <th runat="server">pname</th>
                                <th runat="server">price</th>
                                <th runat="server">stock</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                <td>
                    <asp:Label ID="pidLabel" runat="server" Text='<%# Eval("pid") %>' />
                </td>
                <td>
                    <asp:Label ID="pnameLabel" runat="server" Text='<%# Eval("pname") %>' />
                </td>
                <td>
                    <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                </td>
                <td>
                    <asp:Label ID="stockLabel" runat="server" Text='<%# Eval("stock") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
</asp:Content>
