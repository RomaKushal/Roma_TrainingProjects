﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="StateManagement.Application" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Application State</title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="margin-left: 160px">
            <asp:Button ID="Button1" runat="server" Text="Counter" OnClick="Button1_Click" />
        </div>
        <br />
        <div style="margin-left: 160px">
            <asp:Label ID="Label1" runat="server" Text="Application  Counter Value is  : "></asp:Label>
            &nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
