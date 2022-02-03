<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="Database_Controls.ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listview Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" GroupPlaceholderID="groupplaceholder" ItemPlaceholderID="itemplaceholder" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
                <LayoutTemplate>
                    <table border="1">
                        <tr>
                            <th>Name</th>
                            <th>Address</th>
                            <th>Email</th>
                            <th>Phone</th>
                        </tr>
                        <tr id="groupplaceholder" runat="server"></tr>
                    </table>
                </LayoutTemplate>
                <GroupTemplate>
                    <tr>
                        <tr id="itemplaceholder" runat="server">
                        </tr>
                    </tr>

                </GroupTemplate>
                <ItemTemplate>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Address") %></td>
                    <td><%# Eval("Email") %></td>
                    <td><%# Eval("Phone") %></td>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
