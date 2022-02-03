<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterFormWithValidations.aspx.cs" Inherits="ValidationControls.RegisterFormWithValidations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style type="text/css">
        .auto-style1 {
            width: 547px;
        }

        .auto-style2 {
            width: 155px;
        }

        .auto-style3 {
            width: 128px;
        }

        .auto-style4 {
            width: 163px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1" border="0">
            <tr>
                <th colspan="3"><h2>Registration Details</h2></th>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="NAME : " Font-Size="12pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server" Width="215px"></asp:TextBox>
                </td>
                <td class="auto-style4" style="width:500px;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Employee Name is required." Font-Size="12pt" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="AGE : " Font-Size="12pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtAge" runat="server" Width="212px"></asp:TextBox>
                </td>
                <td class="auto-style4" style="width:500px;">
                    <asp:RangeValidator ID="RangeValidator1" runat="server"
                        ErrorMessage="Age should be between 1 ro 100." ControlToValidate="txtAge" 
                        MaximumValue="100" MinimumValue="1" Type="Integer" ForeColor="Red" SetFocusOnError="True"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="EMAIL : " Font-Size="12pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server" Width="213px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                        ErrorMessage="Invalid email address." ControlToValidate="txtEmail"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="PASSWORD : " Font-Size="12pt"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPassword" runat="server" Width="213px"></asp:TextBox>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="RETYPE PASSWORD : " Font-Size="12pt"></asp:Label>

                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtretypePassword" runat="server" Width="211px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:CompareValidator ID="CompareValidator1" runat="server"
                        ErrorMessage="Passwords do not match." ControlToCompare="txtretypePassword"
                        ControlToValidate="txtPassword" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="126px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
        </table>

    </form>
</body>
</html>
