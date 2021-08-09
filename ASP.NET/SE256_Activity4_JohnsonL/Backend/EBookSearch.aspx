<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EBookSearch.aspx.cs" Inherits="JohnsonL_Activity2.Backend.EBookSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ebook Search</h1>
    <p>Optional Search Criteria to narrow search results</p>
    <p>
        Book Title <asp:TextBox ID ="txtTitle" runat ="server"></asp:TextBox><br />
        Author's Last name <asp:TextBox ID ="txtLast" runat ="server" Columns ="30"></asp:TextBox><br />
        <asp:Button ID ="btnSearch" runat ="server" Text ="Search" OnClick ="btnSearch_Click"/>
    </p>
    <asp:DataGrid ID ="dgResults" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundColumn DataField="Title" HeaderText ="Title"></asp:BoundColumn>
            <asp:BoundColumn DataField="AuthorFirst" HeaderText ="Author First"></asp:BoundColumn>
            <asp:BoundColumn DataField="AuthorLast" HeaderText ="Author Last"></asp:BoundColumn>
            <asp:BoundColumn DataField="DatePublished" HeaderText ="Date Published"></asp:BoundColumn>
            <asp:HyperLinkColumn Text ="Edit" DataNavigateUrlFormatString ="~/Backend/EbookManager.aspx?EBookID={0}" DataNavigateUrlField="EBookID"></asp:HyperLinkColumn>

        </Columns>
    </asp:DataGrid>

    <br />
    <br />
    
    <asp:Repeater ID ="rptSearch" runat = "server">
        <HeaderTemplate>
            <asp:Label ID="lblHeader" runat="server" Text ="Your results" />
        </HeaderTemplate>

        <ItemTemplate>
            <br />
            <asp:Label ID ="lblTitle" runat ="server" Text ='<%# Eval("Title") %>'></asp:Label>
            <asp:Label ID ="lblAuthorFirst" runat ="server" Text ='<%# Eval("AuthorFirst") %>'></asp:Label>
            <asp:Label ID ="lblAuthorLast" runat ="server" Text ='<%# Eval("AuthorLast") %>'></asp:Label>
            <asp:Label ID ="lblDatePublished" runat ="server" Text ='<%# Eval("DatePublished") %>'></asp:Label>
            <asp:HyperLink ID ="hlEdit" runat ="server" Text ="Edit" NavigateUrl ='<%# Eval("EBookID", "EBookManager.aspx?EBookID={0}") %>'></asp:HyperLink>

         </ItemTemplate>
    </asp:Repeater>


    <asp:Literal ID="litResults" runat="server" Text="" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="newContentAside" runat="server">
</asp:Content>
