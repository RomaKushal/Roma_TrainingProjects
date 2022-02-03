<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataCache.aspx.cs" Inherits="UserControlAndCaching.DataCache" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Data Caching Example</h2>
        </div>
        <div>
            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>

            <br />

            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="328px" AllowPaging="True" AutoGenerateRows="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Fields>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" CacheDuration="60" ConnectionString="Data Source=(localdb)\ProjectsV13;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" EnableCaching="True" ProviderName="System.Data.SqlClient" SelectCommand="select * from dbo.Users"></asp:SqlDataSource>
        </div>


    </form>
</body>
</html>
