<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginForm1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="Grey">
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Login Form"></asp:Label>
            <table>
              <tr>
                  <td><asp:Label id="lblogin"  runat="server" Text="Enter Username"></asp:Label></td>
                  <td><asp:TextBox id="tuname" runat="server"></asp:TextBox></td>
                  <td><asp:Label id="lbuname"  runat="server" Text=""></asp:Label></td>
                  
              </tr>
              <tr>
                  <td><asp:Label id="lbpwd"  runat="server" Text="Enter Password"></asp:Label></td>
                  <td><asp:TextBox id="tpwd" runat="server" TextMode="Password"></asp:TextBox></td>
                  <td><asp:Label id="lbpass"  runat="server" Text=""></asp:Label></td>
                  
              </tr>
              <tr>
                  <td><asp:Button id="btlogin" runat="server" Text="Login" OnClick="Btnlogin_Click"></asp:Button></td>   
                  <td><asp:Label id="label"  runat="server" Text=""></asp:Label></td>
                  
              </tr>

            </table>
        </div>
    </form>
</body>
</html>
