<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManagement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <h3>View State demo</h3>
         
            Page Counter:
            
            <asp:Label ID="lblCounter" runat="server" />
         </div>
          <p style="margin-left: 40px">
&nbsp;<asp:Button ID="btnIncrement" runat="server" OnClick="btnIncrement_Click" Text="Add Count" />
          </p>
    </form>
</body>
</html>
