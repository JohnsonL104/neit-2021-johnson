﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="JohnsonL_Activity2.Backend.ControlPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Control Panel</h1>

    <a href ="EBookManager.aspx">Add Ebook</a>
    <br />
    <a href ="EBookSearch.aspx">Search Ebook</a>
    <br />
    <asp:Button ID ="btnLogout" runat ="server" OnClick ="lougoutBtnClick" Text ="Logout" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="newContentAside" runat="server">
</asp:Content>
