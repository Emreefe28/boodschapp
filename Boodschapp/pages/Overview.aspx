<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="Boodschapp.Overview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblName" runat="server"></asp:Label>
    <br />
    <div class="col-xs-4">
    <asp:Table ID="ProductsTable" runat="server" CssClass="table table-bordered"></asp:Table>
    </div>
    </asp:Content>
