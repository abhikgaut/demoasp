<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="demoasp.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:RadioButton ID="male" runat="server" Text="male" OnCheckedChanged="RadioButton1_CheckedChanged" />
        </div>
        <p class="auto-style1">
            <asp:RadioButton ID="female" runat="server" Text="female" OnCheckedChanged="RadioButton2_CheckedChanged" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
