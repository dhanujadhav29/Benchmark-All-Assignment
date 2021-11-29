<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginForm1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          Registration Form</div>
        <table>
            <tr>
                <td><asp:Label id="fname" runat="server" Text="First Name"></asp:Label></td>
                <td><asp:TextBox id="tfname" runat="server"></asp:TextBox></td>
                <td><asp:Label id="lfname" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label id="lname1" runat="server" Text="Last Name"></asp:Label></td>
                <td><asp:TextBox id="tlname" runat="server"></asp:TextBox></td>
                <td><asp:Label id="llname" runat="server" Text=""></asp:Label></td>
            </tr>

            <tr>
                <td><asp:Label id="uname" runat="server" Text="UserName"></asp:Label></td>
                <td><asp:TextBox id="tuname" runat="server"></asp:TextBox></td>
                <td><asp:Label id="luname" runat="server" Text=""></asp:Label></td>
            </tr>

            <tr>
                <td><asp:Label id="pwd" runat="server" Text="Password"></asp:Label></td>
                <td><asp:TextBox id="tpwd" runat="server" TextMode="Password"></asp:TextBox></td>
                <td><asp:Label id="lpwd" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label id="cpwd" runat="server" Text="Confirm Password"></asp:Label></td>
                <td><asp:TextBox id="tcpwd" runat="server" TextMode="Password"></asp:TextBox></td>
                <td><asp:Label id="lcpwd" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label id="addr" runat="server" Text="Address"></asp:Label></td>
                <td><asp:TextBox id="taddr" runat="server"></asp:TextBox></td>
                <td class="auto-style1"><asp:Label id="laddr" runat="server" Text=""></asp:Label></td>
            </tr>

            <tr>
                <td><asp:Label id="dob" runat="server" Text="Date Of birth"></asp:Label></td>
                <td><asp:TextBox id="tdob" runat="server" TextMode="Date"></asp:TextBox></td>
                <td><asp:Label id="ldob" runat="server" Text=""></asp:Label></td>
            </tr>
            
          <tr>
              <td><asp:Button id="bsubmit" runat="server" Text="Submit" OnClick="bsubmit_Click"></asp:Button></td>
              <td><asp:Label id="lsubmit" runat="server" Text=""></asp:Label></td>
          </tr>
        </table>
    </form>
   
</body>
</html>
