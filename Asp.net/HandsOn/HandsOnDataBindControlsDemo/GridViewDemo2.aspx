<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewDemo2.aspx.cs" Inherits="HandsOnDataBindControlsDemo.GridViewDemo2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Eid" DataSourceID="SqlDataSource1" PageSize="3">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Eid" HeaderText="Eid" ReadOnly="True" SortExpression="Eid" />
            <asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
            <asp:BoundField DataField="JoinDate" HeaderText="JoinDate" SortExpression="JoinDate" />
            <asp:BoundField DataField="Did" HeaderText="Did" SortExpression="Did" />
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VirtusaDBConnectionString %>" DeleteCommand="DELETE FROM [Employee] WHERE [Eid] = @Eid" InsertCommand="INSERT INTO [Employee] ([Eid], [Ename], [Salary], [JoinDate], [Did]) VALUES (@Eid, @Ename, @Salary, @JoinDate, @Did)" SelectCommand="SELECT * FROM [Employee]" UpdateCommand="UPDATE [Employee] SET [Ename] = @Ename, [Salary] = @Salary, [JoinDate] = @JoinDate, [Did] = @Did WHERE [Eid] = @Eid">
    <DeleteParameters>
        <asp:Parameter Name="Eid" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Eid" Type="Int32" />
        <asp:Parameter Name="Ename" Type="String" />
        <asp:Parameter Name="Salary" Type="Decimal" />
        <asp:Parameter DbType="Date" Name="JoinDate" />
        <asp:Parameter Name="Did" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Ename" Type="String" />
        <asp:Parameter Name="Salary" Type="Decimal" />
        <asp:Parameter DbType="Date" Name="JoinDate" />
        <asp:Parameter Name="Did" Type="String" />
        <asp:Parameter Name="Eid" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
