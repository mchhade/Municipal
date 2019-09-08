<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Meeting.aspx.cs" Inherits="Municipal.Meeting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MunicipalConnectionString %>" SelectCommand="SELECT * FROM [meeting]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" Visible="False" />
            <asp:BoundField DataField="date_meeting" SortExpression="date_meeting" />
            <asp:HyperLinkField DataTextField="title" SortExpression="title" />
            <asp:BoundField DataField="title" SortExpression="title" Visible="False" />
            <asp:BoundField DataField="description_meeting" HeaderText="description_meeting" SortExpression="description_meeting" Visible="False" />
        </Columns>
    </asp:GridView>
</asp:Content>
