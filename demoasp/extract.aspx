<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="extract.aspx.cs" Inherits="demoasp.extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Choose department number:<asp:DropDownList ID="ddDeptno" runat="server" OnSelectedIndexChanged="ddDeptno1" AppendDataBoundItems="True" AutoPostBack="True">
        <asp:ListItem Value="-1">select</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
   <h2> <asp:GridView ID="gvdata" runat="server" OnSelectedIndexChanged="gvdata_SelectedIndexChanged"></asp:GridView></h2>
</asp:Content>
