<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="demoasp.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 94px;
        }
        .auto-style8 {
            width: 145px;
        }
        .auto-style9 {
            width: 138px;
        }
        .auto-style10 {
            width: 94px;
            height: 23px;
        }
        .auto-style11 {
            width: 145px;
            height: 23px;
        }
        .auto-style12 {
            width: 138px;
            height: 23px;
        }
        .auto-style13 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" Width="559px">
    </asp:GridView>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" OnPageIndexChanging="FormView1_PageIndexChanging">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td class="auto-style10">order ID</td>
                    <td class="auto-style11">order Description</td>
                    <td class="auto-style12">total cost</td>
                    <td class="auto-style13">discount amount</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("orderid") %>'></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("orderdesc") %>'></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("total_bill") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("disAmt") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" OnPageIndexChanging="DetailsView1_PageIndexChanging"></asp:DetailsView>
</asp:Content>
