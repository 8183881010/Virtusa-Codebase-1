<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsViewDemo.aspx.cs" Inherits="HandsOnDataBindControlsDemo.DetailsViewDemo" %>
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
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="pid" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
            <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="stock" HeaderText="stock" SortExpression="stock" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
</asp:Content>
