<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Speech.aspx.cs" Inherits="Municipal.Speech" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MunicipalConnectionString %>" SelectCommand="SELECT * FROM [speech]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" GridLines="None">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" Visible="False" />
            <asp:BoundField DataField="date_speech" SortExpression="date_speech" />
            <asp:HyperLinkField DataTextField="title" SortExpression="description_speech" NavigateUrl="~/DetailSpeech.aspx" DataNavigateUrlFields="id" DataNavigateUrlFormatString="DetailSpeech.aspx?id={0}" Target="_blank" />
        </Columns>
    </asp:GridView>
</asp:Content>
