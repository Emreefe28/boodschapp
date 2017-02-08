<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Boodschapp.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/limiting.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
	    <div class="span12">
            <div class="col-xs-4">
                <asp:Label ID="Label1" runat="server" CssClass="control-label" Text="Product name"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" CssClass="control-label" Text="Product Price"></asp:Label>
                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" onkeypress="return isFloatNumber(this,event);"></asp:TextBox>
                <br />
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            </div>
            <div class="col-xs-4">
                <asp:Table ID="ProductsTable" runat="server" CssClass="table table-bordered"></asp:Table>
            </div>
        </div>
    </div>
</div>
</asp:Content>
