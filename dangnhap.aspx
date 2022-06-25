<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="DoanWebNhomPV.dangnhap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="body">
		<div align="center"><h3>ĐĂNG NHẬP</h3></div>
		<hr>
        <asp:Label ID="Label1" runat="server" Text="Sai tài khoản hoặc mật khẩu" Visible="false" CssClass="label"></asp:Label>
        <div style="margin-top: 40px">
        	<div class="cap">Tài khoản:</div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Email" required></asp:TextBox>
        </div>
        <div style="margin-top: 7px">
        	<div class="cap">Mật khẩu: </div>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" TextMode="Password" required></asp:TextBox>
        </div>
		
		<div align="center" style="margin-top: 20px">
            <asp:Button ID="Button1" runat="server" Text="Đăng nhập" CssClass="button" OnClick="Button1_Click" />
        </div>
		<div align="center" style="margin-top: 15px">Bạn là thành viên mới chưa có tài khoản?<a href="dangky.aspx" style="color: white"> Đăng kí ngay.</a></div>
	</div>
    <link href="css/dangnhap.css" rel="stylesheet" />
    <script src="js/jquery-3.6.0.min.js"></script>
    
</asp:Content>
