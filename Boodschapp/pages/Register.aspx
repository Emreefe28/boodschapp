<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Boodschapp.Pages.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
		    <div class="span12">
                <div class="col-xs-4">
                    <h1 class="display-4">Register</h1>
			        <label class="control-label" for="Name">Name</label>
			        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required="required"></asp:TextBox>
			        <label class="control-label" for="password">Password</label>
			        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" required="required" TextMode="Password"></asp:TextBox>
			        <label class="control-label" for="Banknr">Bank number</label>
			        <asp:TextBox ID="txtBanknr" runat="server" CssClass="form-control" required="required"></asp:TextBox>
			        <br />
			        <asp:Button ID="btnRegister" runat="server" CssClass="btn btn-primary" Text="Register" OnClick="btnRegister_Click" />
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </div>
		    </div>
	    </div>
    </div>
</asp:Content>
