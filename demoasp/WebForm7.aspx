<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="demoasp.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="auto-style6">
        <tr>
            <td>
                <asp:RadioButton ID="rdbHire" runat="server" Text="joining date:" GroupName="G1" OnCheckedChanged="rdbHire_CheckedChanged" AutoPostBack="True"></asp:RadioButton>

            </td>
            <td>
                <asp:TextBox ID="txtStart" runat="server" TextMode="Date"></asp:TextBox>
                and
                <asp:TextBox ID="txtEnd" runat="server" TextMode="Date"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="rdbdno" runat="server" Text="department no:"  GroupName="G1" AutoPostBack="True" OnCheckedChanged="rdbdno_CheckedChanged"></asp:RadioButton></td>
            <td>
                <asp:DropDownList ID="ddldeptno" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="ddldeptno_SelectedIndexChanged">
                    <asp:ListItem Value="-1">select</asp:ListItem>
                </asp:DropDownList>
                </td>
            
        </tr>
        
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            
        </tr>
        
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="dgvdetail" runat="server">
                </asp:GridView>
                </td>
            
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            
        </tr>
        
    </table>
</asp:Content>
