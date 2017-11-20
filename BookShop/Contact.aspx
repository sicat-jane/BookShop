<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BookShop.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Write to us or Give us a call.</h3>
    <address>
        NUS ISS<br />
        Pasir Panjang, SG 645739<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@bookshop.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@bookshop.com">Marketing@example.com</a>
    </address>
</asp:Content>
