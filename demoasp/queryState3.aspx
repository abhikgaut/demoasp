<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="queryState3.aspx.cs" Inherits="demoasp.queryState3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="Javascript" type="text/javascript">
        function func1()
            {
            alert("hello");
            window.open("queryState4.aspx?a=10&b=20&c=30")
            }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="func1()" />
        </div>
    </form>
</body>
</html>
