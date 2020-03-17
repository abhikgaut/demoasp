<%@ Page Title="" Language="C#" MasterPageFile="~/site2.Master" AutoEventWireup="true" CodeBehind="second.aspx.cs" Inherits="demoasp.second" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
        <td>Employee no: </td>
            <td>
                <asp:Label ID="Label1" runat="server" ></asp:Label></td>
            </tr>
            <tr>
         <td>Employee name: </td>
            <td>
                <asp:Label ID="Labelname" runat="server" ></asp:Label></td>
                </tr>
                <tr>
         <td>job: </td>
            <td>
                <asp:Label ID="LabelJob" runat="server" ></asp:Label></td>
                    </tr>
                    <tr>
        <td>manager: </td>
            <td>
                <asp:Label ID="LabelMgr" runat="server" ></asp:Label></td>
                        </tr>
                        <tr>
        <td>hiredate: </td>
            <td>
                <asp:Label ID="LabelHire" runat="server" ></asp:Label></td>
                            </tr>
                            <tr>
        <td>salary: </td>
            <td>
                <asp:Label ID="LabelSal" runat="server" ></asp:Label></td>
                   </tr>
                   <tr>
        <td>commision: </td>
            <td>
                <asp:Label ID="LabelComm" runat="server" ></asp:Label></td>
                </tr>
                <tr>
        <td>department no.: </td>
            <td>
                <asp:Label ID="LabelDno" runat="server" ></asp:Label></td>
                    </tr>
        <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="confirm" OnClick="Button1_Click" /></td>
            </tr>
    </table>
</asp:Content>
