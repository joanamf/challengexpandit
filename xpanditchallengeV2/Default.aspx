<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/master/Site.Master" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>XpandIT Challenge</h1>
        <p class="lead">Gestão de contactos</p>
    </div>

    <div class="row">
        <asp:GridView runat="server" ID="gvContacts" AutoGenerateColumns="False"
            CssClass="table table-hover"
            DataKeyNames="personId"
            BorderWidth="0" GridLines="None"
            AllowPaging="True" AllowSorting="True" OnSorting="gvContacts_Sorting"
            OnPageIndexChanging="gvContacts_PageIndexChanging">
            <PagerStyle CssClass="GridPager" HorizontalAlign="Center" />
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Image ID="imgContactPhoto" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="Nome"
                    SortExpression="Name" />
                <asp:BoundField DataField="MobileNumber" HeaderText="Telemóvel"
                    SortExpression="MobileNumber" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
