<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="demoasp.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/StyleSheet1.css" rel="stylesheet" />
    <script src="scripts/loginValidate.js"></script>
    <style type="text/css">
        .auto-style6 {
            width: 799px;
        }
        .auto-style7 {
            width: 100%;
            height: 329px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style7">
        <tr>
            <td>Username:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtuser" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td class="auto-style6"><asp:TextBox ID="txtpass" runat="server" TextMode="Password" ClientIDMode="Static" ></asp:TextBox></td>
            <td></td>
        </tr> 
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr> 
        <tr>
            <td>
                <asp:Button ID="btn1" runat="server" Text="LOGIN" OnClick="btn1_Click" OnClientClick="return validate()"/>
            </td>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </td>
            <td></td>
        </tr> 
    </table>
</asp:Content>
