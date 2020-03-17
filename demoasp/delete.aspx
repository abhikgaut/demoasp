<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="demoasp.delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/StyleSheet1.css" rel="stylesheet" />
    <script src="scripts/delete.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table >
        <tr>
            <td>Enter employee id to delete:</td>
            <td>
                <asp:TextBox ID="Texteno" runat="server" ClientIDMode="Static"></asp:TextBox></td>            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" OnClientClick="return DValidate()" /></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
