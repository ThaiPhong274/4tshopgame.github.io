<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="DoanWebNhomPV.dangky" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">
            <div align="center" style="padding-top: 10px"><strong>ĐĂNG KÍ THÀNH VIÊN</strong></div>
            <hr>
            <div style="margin: 2px;padding-top: 20px">
                <div style="width: 50%; float: left" align="right">Email:</div>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Email" required></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Email không hợp lệ" Visible="false" CssClass="label"></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="Email đã tồn tại" Visible="false" CssClass="label"></asp:Label>
            </div>
            <div style="margin: 2px">
                <div style="width: 50%; float: left" align="right">Mật khẩu:</div>
                <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter password" required></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Vui lòng nhập đủ độ dài tối thiểu" Visible="false" CssClass="label"></asp:Label>
            </div>
            <div style="width: 50%; float: right" align="left">(Tối thiểu 6 kí tự)</div><br />
            <br>
            <div style="margin: 2px">
                <div style="width: 50%; float: left" align="right">Nhập lại mật khẩu:</div>
                <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter password again" required></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Mật khẩu không khớp" Visible="false" CssClass="label"></asp:Label>
            </div>
            <div style="margin: 2px">
                <div style="width: 50%; float: left" align="right">Họ và tên:</div>
                <asp:TextBox ID="TextBox4" runat="server" placeholder="Họ và tên" required></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Vui lòng điền đầy đủ thông tin" Visible="false" CssClass="label"></asp:Label>
            </div>
            <div style="margin: 2px; padding-top: 4px">
                <div style="width: 100%; float: left" align="center">
                    <asp:Button ID="Button1" runat="server" Text="Đăng ký" OnClick="Button1_Click" />
                </div>
            </div>
            <p id="hienthi"></p>
    </div>
    <link href="css/dangky.css" rel="stylesheet" />
</asp:Content>
