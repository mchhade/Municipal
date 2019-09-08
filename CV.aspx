<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="CV.aspx.cs" Inherits="Municipal.CV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style1 {
            margin-right: 109px;
        }
    </style>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 runat="server" style="color: #0000FF">Personal information</h1>
    <table><tr><td><asp:Label runat="server" ForeColor="Black" Font-Size="Medium" Font-Bold="True">The Mayor  : </asp:Label></td>
        <td><asp:Label runat="server" ID="name"></asp:Label></td></tr>
    <tr><td><asp:Label runat="server" Font-Bold="true">Birth Date :</asp:Label></td><td><asp:Label runat="server" ID="bdates"></asp:Label></tr>
        <tr><td><asp:Label runat="server" Font-Bold="true">Address :</asp:Label></td><td><asp:Label runat="server" ID="address"></asp:Label></td></tr>
    <tr><td><asp:Label runat="server" Font-Bold="true">Father :</asp:Label></td><td><asp:Label runat="server" ID="father"></asp:Label></td></tr>
   <tr><td><asp:Label runat="server" Font-Bold="true">Mother :</asp:Label></td><td><asp:Label runat="server" ID="mother"></asp:Label></td></tr>
    <tr><td><asp:Label runat="server" Font-Bold="true">Marital status :</asp:Label></td><td><asp:Label runat="server" ID="status"></asp:Label></td></tr>
    <tr><td><asp:Label runat="server" ID="lkids" Font-Bold="true">Kids :</asp:Label></td><td><asp:Label runat="server" ID="kids"></asp:Label></td></tr>
</table>
    <hr/>
    <h1 runat="server" style="color:blue">Education </h1>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MunicipalConnectionString %>" SelectCommand="SELECT [year_education], [description_education] FROM [education]"></asp:SqlDataSource>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BorderWidth="0px" GridLines="None" Width="193px">
        <Columns>
            <asp:BoundField DataField="year_education" SortExpression="year_education"  ControlStyle-BorderWidth="0" >
<ControlStyle BorderWidth="0px"></ControlStyle>
            </asp:BoundField>
            <asp:BoundField DataField="description_education" ControlStyle-BorderWidth="0"  SortExpression="description_education" >
<ControlStyle BorderWidth="0px"></ControlStyle>
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    <hr />
     <h1 runat="server" style="color:blue">Professionel </h1>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MunicipalConnectionString %>" SelectCommand="SELECT [description_professionel], [year_professionel] FROM [professionell]"></asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BorderWidth="0px" DataSourceID="SqlDataSource2" GridLines="None" CssClass="auto-style1" Width="257px">
        <Columns>
            
            <asp:BoundField DataField="year_professionel" SortExpression="year_professionel" />
            <asp:BoundField DataField="description_professionel" SortExpression="description_professionel" />
        </Columns>
    </asp:GridView>
</asp:Content>
