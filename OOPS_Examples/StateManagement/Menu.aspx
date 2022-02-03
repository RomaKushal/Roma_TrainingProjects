<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="StateManagement.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> State Management</title>
        <style type="text/css">  
        body {  
            background-color: mediumaquamarine;  
            font-family: Arial;  
            font-size: 9pt;  
            color: #444;  
        }  
  
        .ParentMenu, .ParentMenu:hover {  
            width: 100px;  
            background-color: #fff;  
            color: #333;  
            text-align: center;  
            height: 30px;  
            line-height: 30px;  
            margin-right: 5px;  
        }  
  
            .ParentMenu:hover {  
                background-color: #ccc;  
            }  
  
        .ChildMenu, .ChildMenu:hover {  
            width: 110px;  
            background-color: #fff;  
            color: #333;  
            text-align: left;  
            height: 30px;  
            line-height: 30px;  
            margin-top: 5px;  
            margin-left:10px;
        }  
  
            .ChildMenu:hover {  
                background-color: #ccc;  
            }  
  
        .selected, .selected:hover {  
            background-color: #A6A6A6 !important;  
            color: #fff;  
        }  
  
        .level2 {  
            background-color: #fff;  
        }  
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BorderStyle="None" Font-Size="Large">  
                <Items>
                    <asp:MenuItem Text="Client Side" Value="Client Side">
                        <asp:MenuItem NavigateUrl="~/ViewState.aspx" Text="View State" Value="View State"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/HiddenField.aspx" Text="Hidden Field" Value="Hidden Field"></asp:MenuItem>
                        <asp:MenuItem Text="Cookies" Value="Cookies" NavigateUrl="~/Cookie.aspx"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/QueryString_1.aspx" Text="QueryString" Value="QueryString"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Server Side" Value="Server Side">
                        <asp:MenuItem NavigateUrl="~/Session.aspx" Text="Session" Value="Session"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Application.aspx" Text="Application" Value="Application"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
        <LevelMenuItemStyles>  
            <asp:MenuItemStyle CssClass="ParentMenu" />  
            <asp:MenuItemStyle CssClass="ChildMenu" />  
            <asp:MenuItemStyle CssClass="ChildMenu" />  
        </LevelMenuItemStyles>  
        <StaticSelectedStyle CssClass="selected" />  
    </asp:Menu>  
        </div>
    </form>
</body>
</html>
