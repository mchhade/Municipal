<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Municipal.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table>
    <tr>
        <td style="position:relative">
           <asp:Label runat="server" Text="News" BackColor="Gray" Height="100%" Width="100%"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="date_news" SortExpression="date_news" />
                    <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="DetailNews.aspx?id={0}" DataTextField="title" NavigateUrl="~/DetailNews.aspx" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MunicipalConnectionString %>" SelectCommand="SELECT * FROM [news]"></asp:SqlDataSource>
       
        </td>
        <td style="margin-right:150px"> 
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
           
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:Image ID="Image1" runat="server" Height="200%" Width="200%"  />
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
</table>
</asp:Content>
