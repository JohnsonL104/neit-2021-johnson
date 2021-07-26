<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <asp:TextBox ID ="txtLCD" runat="server" Columns ="20"></asp:TextBox>
        </tr>
        <tr>
            <td><asp:Button ID="btn1" Text =  "7" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btn2" Text =  "8" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btn3" Text =  "9" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" Width="22px" /></td>
            <td><asp:Button ID="btnCls" Text =  "C" runat="server" OnClick="clsBtnClick" BackColor="#EFEFEF" BorderStyle="Solid"/></td> 
        </tr>
        <tr>
            <td><asp:Button ID="btn4" Text =  "4" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btn5" Text =  "5" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" Width="22px" /></td>
            <td><asp:Button ID="btn6" Text =  "6" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btnAdd" Text =  "+" runat="server" OnClick="opBtnClick" BackColor="#EFEFEF" BorderStyle="Solid"/></td> 
        </tr>
        <tr>
            <td><asp:Button ID="btn7" Text =  "1" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btn8" Text =  "2" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btn9" Text =  "3" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            <td><asp:Button ID="btnMin" Text =  "-" runat="server" OnClick="opBtnClick" BackColor="#EFEFEF" BorderStyle="Solid"/></td> 
        </tr>
        <tr>
            
           
            <td><asp:Button ID="btn0" Text =  "0" runat="server" OnClick="numBtnClick" BackColor="#EFEFEF" BorderStyle="Solid" /></td>
            
            <td><asp:Button ID="btnDiv" Text =  "/" runat="server" OnClick="opBtnClick" BackColor="#EFEFEF" BorderStyle="Solid"/></td> 
            <td><asp:Button ID="btnMul" Text =  "*" runat="server" OnClick="opBtnClick" BackColor="#EFEFEF" BorderStyle="Solid"/></td> 
            <td><asp:Button ID="btnEquals" Text =  "=" runat="server" OnClick="equalsBtnClick" BackColor="#EFEFEF" BorderStyle="Solid"/></td>
        </tr>
    </table>

</asp:Content>
