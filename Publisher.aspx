<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Publisher.aspx.cs" Inherits="Municipal.Publisher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function hideduration() {
            
            document.getElementById("myP").style.visibility ="collapse";
        }
        function showduration() {
            document.getElementById("myP").style.visibility = "visible";
        }
    </script>
    <style>
        
.button2 {
  background-color: #4CAF50; /* Green */
  border: none;
  color: white;
  padding: 16px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  -webkit-transition-duration: 0.4s; /* Safari */
  transition-duration: 0.4s;
  cursor: pointer;
}
.button4 {
  background-color: white;
  color: black;
  border: 2px solid #e7e7e7;
}
.button4:hover {background-color: #e7e7e7;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
         
    
    <table>
        <tr>
            <td> <asp:Label runat="server" Text="First Name"></asp:Label></td><td> <asp:TextBox runat="server" ID="firstname"></asp:TextBox></td>
        </tr>
         <tr>
            <td> <asp:Label runat="server" Text="Last Name"></asp:Label></td><td> <asp:TextBox runat="server" ID="lastname"></asp:TextBox></td>
        </tr>
         <tr>
            <td> <asp:Label runat="server" Text="Place"></asp:Label></td><td> <asp:TextBox runat="server" ID="place"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="Duration"></asp:Label></td>
            <td><asp:RadioButton ID="Unlimited" runat="server" onclick="hideduration()" Text="Unlimited"  GroupName="Duration"/><asp:RadioButton onclick="showduration()" ID="Limited" GroupName="Duration" runat="server" Text="Limited" /></td>
        </tr>
        <tr id="myP">
            <td><asp:Label runat="server" Text="Time :"></asp:Label></td><td><asp:Label runat="server" Text="From" ID="labelfrom"></asp:Label>
             <asp:TextBox runat="server" ID="from"></asp:TextBox></td>
            <td><asp:Label runat="server" Text="To"></asp:Label></td><td><asp:TextBox runat="server" ID="to"></asp:TextBox></td>
            </tr>
         <tr>
             <td><asp:Label runat="server" Text="Number of Publisher"></asp:Label></td><td><asp:ListBox ID="Number" runat="server" Rows="1"></asp:ListBox>
             </td>
         </tr>
         <tr>
             <td><asp:Label runat="server" Text="Type"></asp:Label></td><td><asp:ListBox ID="type" runat="server" Rows="1" ></asp:ListBox></td>
         </tr>
        <tr>
            <td><asp:Button runat="server" Text="Submit" ID="submit"  CssClass="button2 button4"  OnClick="submit_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
