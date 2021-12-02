<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Assign1ConnectionString %>" SelectCommand="SELECT * FROM [Dept]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <HeaderTemplate>Department Data
            <br />
            <table>
            <thead>
                <th>Department ID</th>
                <th>Department Name</th>
                <th>Department Location</th>
            </thead>

            
        </HeaderTemplate>
            <ItemTemplate>
                <tr style="background-color:aqua">
                    <td><asp:Label id="dno" runat="server" Text='<%#Bind("dno")%>'></asp:Label></td>
                    <td><asp:Label id="dname" runat="server" Text='<%#Bind("dname")%>'></asp:Label></td>
                    <td><asp:Label id="loc" runat="server" Text='<%#Bind("location")%>'></asp:Label></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                 <tr style="background-color:blueviolet">
                    <td><asp:Label id="dno" runat="server" Text='<%#Bind("dno")%>'></asp:Label></td>
                    <td><asp:Label id="dname" runat="server" Text='<%#Bind("dname")%>'></asp:Label></td>
                    <td><asp:Label id="loc" runat="server" Text='<%#Bind("location")%>'></asp:Label></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                <td colspan="4">
                    End Of Report
                </td>
            </table>
            </FooterTemplate>
        </asp:Repeater>
 </asp:Content>
