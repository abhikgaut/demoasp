﻿<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="demoasp.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table  >
                <tr>
                    <td >Employee No</td>
                    <td >
                        <asp:TextBox ID="txteno" runat="server" ClientIDMode="Static" AutoPostBack="True" OnTextChanged="txteno_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >Employee Name</td>
                    <td >
                        <asp:TextBox ID="txtname" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >job</td>
                    <td >                    
                        <asp:TextBox ID="txtjob" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >manager ID</td>
                    <td >
                        <asp:TextBox ID="txtmid" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>hiredate</td>
                    <td >
                        <asp:TextBox ID="txtdate" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >sal</td>
                    <td >
                        <asp:TextBox ID="txtsal" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >commision</td>
                    <td>
                        <asp:TextBox ID="txtcom" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >deopno</td>
                    <td >
                        <asp:TextBox ID="txtdno" runat="server" ClientIDMode="Static"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Label ID="Label1" runat="server" ></asp:Label>
                    </td>
                    <td >
                        &nbsp;</td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"  style="height: 26px"/></td>
                </tr>
            </table>
</asp:Content>
