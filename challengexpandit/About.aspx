<%@ Page Title="Gestão de contactos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="challengexpandit.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <asp:GridView ID="gridViewContacts" runat="server" AutoGenerateColumns="false"
        DataKeyNames="idContact">

    </asp:GridView>
    
    <h3>Your applicdation description page.</h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>
