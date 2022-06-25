<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="DoanWebNhomPV.sanpham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="sanpham">
        <asp:DataList ID="DataList1" runat="server" CssClass="datalist" >
            <ItemTemplate>
                <div style="width: 80%; margin-left: 10%; margin-top: 10px;text-align:center;box-sizing:border-box">
                    <img src='<%#Eval("anh") %>' style="width:80%"/>
                </div>
                <br>
                <div id="tensanpham"><%#Eval("tensp") %></div>
                <br>
                <div style="margin-left: 10%; width: 80%"><%#Eval("mota") %></div>
                <br>
                <div style="margin-left: 10%">
                    <button style="background-color: red; color: white; border-color: red; border-radius: 4px; width: 150px; height: 45px;">Mua ngay</button>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <link href="css/sanpham.css" rel="stylesheet" />

</asp:Content>
