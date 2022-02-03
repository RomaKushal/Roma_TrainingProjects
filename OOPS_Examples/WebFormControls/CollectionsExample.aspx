<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CollectionsExample.aspx.cs" Inherits="WebFormControls.CollectionsExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Collections</title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Collections Examples </h2>
        </div>
        <table>
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="ArrayList" Width="170px" OnClick="Button1_Click" /></td>
                <td></td>
                <td><asp:Button ID="Button2" runat="server" Text="Hashtable" OnClick="Button2_Click" Width="119px" /></td>
                <td></td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="SortedList" OnClick="Button3_Click" /></td>
            </tr>
        </table>
        <div>
            <h2> Generic Collections Examples </h2>
        </div>
        <table>
            <tr>
                <td><asp:Button ID="Button4" runat="server" Text="List" Width="170px" OnClick="Button4_Click" /></td>
                <td></td>
                <td><asp:Button ID="Button5" runat="server" Text="Dictionary" OnClick="Button5_Click" Width="119px" /></td>
                <td></td>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="SortedList" OnClick="Button6_Click" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
