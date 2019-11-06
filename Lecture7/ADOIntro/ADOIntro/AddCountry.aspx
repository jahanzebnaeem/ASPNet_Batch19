<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCountry.aspx.cs" Inherits="ADOIntro.Country" %>
<asp:Content ID="PageContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Button ID="btnSave" runat="server" Text="Save" />

</asp:Content>
