<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EBookManager.aspx.cs" Inherits="JohnsonL_Activity2.Backend.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <a href ="~/Backend/ControlPanel.aspx">Back to Control Panel</a>
        <h1>Add EBook</h1>
        <table>
            <tr>
                <td>EBook ID</td>
                <td><asp:Label ID ="lblID" runat ="server"/></td>
            </tr>
            <tr>
                <td>Title</td>
                <td><asp:TextBox ID ="txtTitle" runat ="server"/></td>
            </tr>
            <tr>
                <td>Author's First Name</td>
                <td><asp:TextBox ID ="txtFName" runat ="server"/></td>
            </tr>
            <tr>
                <td>Author's Last Name</td>
                <td><asp:TextBox ID ="txtLName" runat ="server"/></td>
            </tr>
            <tr>
                <td>Author's Email</td>
                <td><asp:TextBox ID ="txtEmail" runat ="server"/></td>
            </tr>
            <tr>
                <td>Date Published</td>
                <td><asp:Calendar ID ="calDate" runat ="server"/></td>
            </tr>
            <tr>
                <td>Date Rental Expires</td>
                <td><asp:Calendar ID ="calDateExpires" runat ="server"/></td>
            </tr>
            <tr>
                <td>Number of Pages</td>
                <td><asp:TextBox ID ="txtPages" runat ="server"/></td>
            </tr>
            <tr>
                <td>Price</td>
                <td><asp:TextBox ID ="txtPrice" runat ="server"/></td>
            </tr>
            <tr>
                <td>Bookmark page</td>
                <td><asp:TextBox ID ="txtBookmark" runat ="server"/></td>
            </tr>
            
        </table>
        <br />
        <asp:Button ID ="btnDone" text="Done" runat="server" OnClick="doneBtnClick"/>
        <br />
        <asp:Label ID = "lblFeedback" runat="server"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="newContentAside" runat="server">
</asp:Content>
