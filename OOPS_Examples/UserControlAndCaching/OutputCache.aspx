<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputCache.aspx.cs" Inherits="UserControlAndCaching.OutputCache" %>
<%@ OutputCache Duration="5" VaryByParam="txtName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Output Cache Example</h2>
        </div>

        <div>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="91px" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
