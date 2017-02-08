<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Boodschapp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
		<div class="span12">
            <div class="col-xs-4">
                <h1 class="display-4">Login</h1>
			    <label class="control-label"  for="Email" >Email</label>
			    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required="required"></asp:TextBox>
			    <label class="control-label" for="password">Password</label>
			    <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" required="required" TextMode="Password"></asp:TextBox>
			    <a href="Register.aspx">No account? Register</a>
			    <br />
			    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
		</div>
	</div>
</div>
</asp:Content>

