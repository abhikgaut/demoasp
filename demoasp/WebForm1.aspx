<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="demoasp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script lang ="Javascript" type="text/Javascript">
        function validate()
        {
            
            var eno = document.getElementById("txteno").value;
            var ename = document.getElementById("txtname").value;
            var job = document.getElementById("txtjob").value;
            var mgr = document.getElementById("txtmid").value;
            var hd = document.getElementById("txtdate").value;
            var sal = document.getElementById("txtsal").value;
            var comm = document.getElementById("txtcom").value;
            var dno = document.getElementById("txtdno").value;
            //alert("hello");
            if (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && dno.length != 0)
                return true;
            else
            {
                alert("enter all details");
                return false;
            }
            
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 421px;
        }
        .auto-style2 {
            width: 393px;
        }
        .auto-style5 {
            width: 393px;
            height: 4px;
        }
        .auto-style6 {
            width: 421px;
            height: 4px;
        }
        .auto-style7 {
            height: 85px;
            margin-bottom: 0px;
        }
        .auto-style8 {
            width: 393px;
            height: 16px;
        }
        .auto-style9 {
            width: 421px;
            height: 16px;
        }
        .auto-style10 {
            width: 393px;
            height: 2px;
        }
        .auto-style11 {
            width: 421px;
            height: 2px;
        }
    </style>
</head>
<body style="width: 660px; height: 64px">
    <form id="form1" runat="server">
        <div>
           
            <table class="auto-style7" >
                <tr>
                    <td class="auto-style2">Employee No</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txteno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Employee Name</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">job</td>
                    <td class="auto-style9">                    
                        <asp:TextBox ID="txtjob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">manager ID</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtmid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">hiredate</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">sal</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">commision</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtcom" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">deopno</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button2" runat="server" Text="Button" OnClientClick="return validate()" OnClick="Button2_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
