<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormControls.aspx.cs" Inherits="WebFormControls.FormControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 177px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <h3>Textbox, Label,Literal & Button</h3>
                </td>
                <td class="auto-style4"></td>
                <td>
                    <h3>File Upload</h3>
                </td>
                <td></td>
                <td>
                    <h3>Placeholder Example</h3>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td class="auto-style4"></td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                <td></td>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal></td>
                <td class="auto-style4"></td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" /></td>
                <td></td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Click" OnClick="Button3_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                <td class="auto-style4"></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" /></td>
                <td class="auto-style4"></td>
                <td></td>
                <td></td>
            </tr>
        </table>


        <div>
            <h2>Radio Button Example</h2>
        </div>
        <div>
            <asp:RadioButton ID="rdbFemale" runat="server" Text="Female" />
            &nbsp;<asp:RadioButton ID="rdbMale" runat="server" Text="Male" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Submit" OnClick="Button4_Click" />
            &nbsp;
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <h1>Link Button and Hyper Link Example</h1>
        </div>
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click to Link Button</asp:LinkButton>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">Click on Hyper Link</asp:HyperLink>
        </div>
    </form>
</body>
</html>
