<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="DoanWebNhomPV.giohang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="position: relative; height: 1100px">
        <div id="contentcart" style="position: relative">
            <div id="sp_da_them">
                <div id="xoa_all_sp">
                    <asp:LinkButton ID="clear_all" runat="server" OnClick="clear_all_Click">XÓA TẤT CẢ SẢN PHẨM</asp:LinkButton>
                </div>
                <div id="spmua" style="margin-top: 20px; width:80%; background-color:#231E1E; color:white">
                    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red" Visible="false"></asp:Label>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Width="100%" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:TemplateField HeaderText="Hình ảnh" ItemStyle-Width="28%">
                                <ItemTemplate>
                                    <img alt="anh" src='<%#Eval("anh") %>' style="width: 100%;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tên sản phẩm" ItemStyle-Width="40%">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("tensp") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Đơn giá" ItemStyle-Width="15%">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%#Eval("dongia") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Số lượng" ItemStyle-Width="10%">
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" Text="-" Width="30%" CommandName="Giam" CommandArgument='<%#Eval("masp") %>' />
                                    <label for="css"><%#Eval("sl") %></label>
                                    <asp:Button ID="Button2" runat="server" Text="+" Width="30%" CommandName="Tang" CommandArgument='<%#Eval("masp") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-Width="12%">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="RemoveItem" CommandArgument='<%#Eval("masp") %>'><i class="fa fa-trash" style="font-size: 20px;"></i></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <div id="tong_tien" style="position: absolute; right: 30px; top: 0px">
                <p style="text-align: center;">Thông tin đơn hàng:</p>
                <hr>
                <p>Số lượng:<span id="slsp"></span></p>
                <hr>
                <p>Tạm tính:<span id="tamtinh"></span></p>
                <hr>
                <p>Thành tiền:<span id="thanhtien"></span></p>
                <hr>
                <button type="button" class="xac_nhan_cart" onclick="xacnhan()">XÁC NHẬN MUA HÀNG</button>
                <div id="sotrang"></div>
            </div>
        </div>
    </div>
    <link href="css/giohang.css" rel="stylesheet" />
</asp:Content>
