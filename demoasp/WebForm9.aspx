<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="demoasp.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
            width: 111px;
        }
        .auto-style8 {
            width: 111px;
        }
        .auto-style9 {
            width: 111px;
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table >
        <tr>
            <td class="auto-style7">employee no:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtEname" runat="server" OnTextChanged="Unnamed1_TextChanged"></asp:TextBox>
            </td>
           <td class="auto-style6">
               <asp:RequiredFieldValidator runat="server" ErrorMessage="cannot be blank!!" ControlToValidate="txtEname" Display="None"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="auto-style8">Employee name:</td>
            <td>
                <asp:TextBox ID="txtEno" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="cannot be blank!!" ControlToValidate="txtEno" Display="None"></asp:RequiredFieldValidator></td>    
        </tr>
        <tr>
            <td class="auto-style8">password:</td>
            <td>
                <asp:TextBox ID="Password1" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                </td>
        </tr>
        <tr>
            <td class="auto-style8">confirm password:</td>
            <td>
                <asp:TextBox ID="Password2"  runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator runat="server" ErrorMessage="password not same" ControlToCompare="Password1" ControlToValidate="Password2" Display="None"></asp:CompareValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style8">
                salary</td>
            <td>
                <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSal" ErrorMessage="enter value in range" MaximumValue="50000" MinimumValue="10000" Type="Double" Display="None"></asp:RangeValidator>
            </td>
   
        </tr>
        <tr>
            <td class="auto-style9">
                Pancard</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtPan" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPan" Display="None" ErrorMessage="enter valid pan no" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]{1}$"></asp:RegularExpressionValidator>
            </td>
   
        </tr>
        <tr>
            <td class="auto-style8">
                date of birth</td>
            <td>
                <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtDob" Display="None" ErrorMessage="age must be 21 t o58" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
   
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="button1" runat="server" Text="Button" OnClick="button1_Click" />
            </td>
            <td>
                &nbsp;</td>
   
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" Width="177px" />
            </td>
            <td>&nbsp;</td>
   
        </tr>
    </table>
</asp:Content>
