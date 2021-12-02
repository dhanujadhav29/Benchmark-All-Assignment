<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="UrlRouting.GridViewPage" %>
<%@ Import Namespace="System.Web.Routing" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText ="Title">
                  <ItemTemplate>
                      <asp:HyperLink runat="server" text='<%#Eval("Title")%>' href='<%#GetRouteUrl("RouteForArticle",new {id=Eval("Id"),Title=getTitle(Eval("Title"))})%>' runat="server"></asp:HyperLink>
                  </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Desc">
                      <ItemTemplate>
                      <asp:Label text='<%#Eval("Desc")%>' runat="server"></asp:Label>
                  </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Author">
                      <ItemTemplate>
                      <asp:Label text='<%#Eval("Author")%>' runat="server"></asp:Label>
                  </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
