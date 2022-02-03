<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="StateManagement.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hdValue" runat="server" />
            <asp:Button ID="btnViewHiddenField" runat="server" Text="View Hidden Field Value" Font-Size="Large" OnClick="btnViewHiddenField_Click" />
        &nbsp;<br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
        </div>
    </form>
</body>
</html>
