<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString_1.aspx.cs" Inherits="StateManagement.QueryString_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 440px">
            <asp:Label ID="Label1" runat="server" Text="Enter Value : " Font-Size="12pt"></asp:Label>
            &nbsp;<asp:TextBox ID="txtValue" runat="server" Width="195px"></asp:TextBox>
            <br />
            
        </div>
        <br />
        <div style="margin-left: 480px">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="208px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
