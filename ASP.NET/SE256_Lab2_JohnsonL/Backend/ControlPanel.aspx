<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="JohnsonL_Activity2.Backend.ControlPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Control Panel</h1>

    <asp:Button ID ="btnAddShow" runat ="server" Text ="Add Show" />
    <br />
    <asp:Button ID ="btnLogout" runat ="server" OnClick ="lougoutBtnClick" Text ="Logout" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="newContentAside" runat="server">
</asp:Content>
