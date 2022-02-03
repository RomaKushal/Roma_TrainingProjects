<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="StateManagement.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <h2>Cookie Example</h2>
        </div>
        <div style="margin-left: 280px">
            <asp:Button ID="btnCreate" runat="server" Text="Create Cookie" Width="160px" Font-Size="12pt" OnClick="btnCreate_Click" />&nbsp;
            <asp:TextBox ID="txtCreate" runat="server" Width="278px"></asp:TextBox>
        &nbsp;
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <div><br /></div>
        <div style="margin-left: 280px">
            <asp:Button ID="btnRetrieve" runat="server" Text="Retrieve Cookie" Width="161px" Font-Size="12pt" OnClick="btnRetrieve_Click" />&nbsp;
            <asp:TextBox ID="txtRetrieve" runat="server" Width="277px"></asp:TextBox>
        </div>
        <div style="margin-left: 400px">
        </div>
    </form>
</body>
</html>
