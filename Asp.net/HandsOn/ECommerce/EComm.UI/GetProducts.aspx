<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetProducts.aspx.cs" Inherits="EComm.UI.GetProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 50%">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Vertical" PageSize="3" DataKeyNames="PId">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                        <asp:BoundField DataField="Pid" HeaderText="Pid" SortExpression="Pid" />
                        <asp:BoundField DataField="Pname" HeaderText="Pname" SortExpression="Pname" />
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"  DeleteMethod="DeleteProduct" SelectMethod="GetProducts" TypeName="EComm.BusinessLayer.ProductService" UpdateMethod="UpdateProduct">
                    <DeleteParameters>
                        <asp:Parameter Name="Pid" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Price" Type="Int32" />
                        <asp:Parameter Name="Stock" Type="Int32" />
                        <asp:Parameter Name="Pid" Type="Int32" />
                         <asp:Parameter Name="Pname" Type="String" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
