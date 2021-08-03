<%@ Page Title="Shows" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shows.aspx.cs" Inherits="JohnsonL_Activity2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        Search Your Favorite shows:
        <asp:TextBox runat="server"></asp:TextBox>
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="newContentAside" runat="server">
    <h1><%: Title %></h1>
         <h2>Popular now</h2>
            <h3>Breaking Bad</h3>
            <ul>
                <li>USA</li>
                <li>Japan</li>
                <li>EU</li>
            </ul>
</asp:Content>
