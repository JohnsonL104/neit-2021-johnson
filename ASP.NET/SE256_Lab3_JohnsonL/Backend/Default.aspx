<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JohnsonL_Activity2.Backend.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Login </h1>
        <br />
        Username: <asp:TextBox ID ="txtUser" runat ="server"/>
        <br />
        Password: <asp:TextBox ID ="txtPass" runat ="server" TextMode ="Password" />
        <br />
        <asp:Button ID ="btnLogin" runat ="server" OnClick="loginBtnClick" Text ="Login"/>
        <asp:Label ID ="lblFeedback" runat ="server"/>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="newContentAside" runat="server">
</asp:Content>
