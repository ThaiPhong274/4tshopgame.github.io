<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DoanWebNhomPV.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
			<article style="width: 70%; margin: 0 auto;">
				<div id="slideShow" style="background: #231E1E; border-radius: 10px">
					<div class="images fade" >
						<a href="sanpham.aspx?product=40"><img src="img/content/jc4/jc4-new.jpg" style="width:100%; height: 350px; border-radius: 10px;" alt="Chọn"></a>
					</div>
						<div class="images fade" >
						<a href="sanpham.aspx?product=5"><img src="img/content/bf5/bf5-new.jpg" style="width:100%; height: 350px; border-radius: 10px" alt="Chọn"></a>
					</div>
					<div class="images fade" >
						<a href="sanpham.aspx?product=39"><img src="img/content/ds3/ds3-new.jpg" style="width:100%; height: 350px; border-radius: 10px" alt="Chọn"></a>
					</div>
					<div class="images fade" >
						<a href="sanpham.aspx?product=6"><img src="img/content/hm2/hm2-new.jpg" style="width:100%; height: 350px; border-radius: 10px" alt="Chọn"></a>
					</div>
					<div class="images fade">
						<a href="sanpham.aspx?product=8"><img src="img/content/aco/aco-new.jpg" style="width:100%; height: 350px; border-radius: 10px" alt="Chọn"></a>
					</div>
					<div class="images fade" >
						<a href="sanpham.aspx?product=4"><img src="img/content/sottr/sottr-new.jpg" style="width:100%; height: 350px; border-radius: 10px" alt="Chọn"></a>
					</div>
					<a class="prev" onclick="plusSlides(-1)" style="margin-left: -58px">❮</a>
  					<a class="next" onclick="plusSlides(1)" style="margin-right: -58px">❯</a>
				</div>
			</article>
		<div style="text-align:center;margin-top: 5px;margin-bottom: 3px;">		  	
  			<span class="dot" onclick="currentSlide(1)"></span> 
			<span class="dot" onclick="currentSlide(2)"></span> 
			<span class="dot" onclick="currentSlide(3)"></span>
			<span class="dot" onclick="currentSlide(4)"></span>  
			<span class="dot" onclick="currentSlide(5)"></span> 
			<span class="dot" onclick="currentSlide(6)"></span> 
			</div>
		</div>
    <div style="position: relative; height: 1100px">
        <div id="menulist">
            <asp:DataList runat="server" ID="DataList1" CssClass="datalist" OnItemCommand="DataList1_ItemCommand">
                <HeaderTemplate>
                    <p align="center"><strong>THỂ LOẠI</strong></p>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" cssclass="Linkbtn" runat="server" CommandArgument='<%#Eval("maloai") %>'>
                        <asp:Panel ID="Panel1" runat="server" CssClass="category">
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("tenloai") %>'></asp:Label>
                        </asp:Panel>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div id="productlist">
            <%--Mã loại--%>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="1" />
            <%--Tiêu đề loại sản phẩm--%>
            <div style="width: 100%;padding-top:20px">
                <asp:Label ID="Label2" runat="server" Text="Nổi bật" class="tieudesp"></asp:Label></div>
            <asp:ListView runat="server" ID="ListView1" OnPagePropertiesChanging="List_PagePropertiesChanging" GroupPlaceholderID="GroupPlaceholder" ItemPlaceholderID="ItemPlaceholder">
                <LayoutTemplate>
                    <div id="GroupPlaceholder" runat="server"></div>
                </LayoutTemplate>
                <GroupTemplate>
                    <div id="ItemPlaceholder" runat="server"></div>
                </GroupTemplate>
                <ItemTemplate>
                    <div class="product">
                        <a href="sanpham.aspx?product=<%#Eval("masp") %>" style="text-decoration: none">
                            <img src='<%#Eval("anh") %>' id="hinhsp" style="margin-top: 25px" />
                            <div><figcaption style="color: white;"><%#Eval("tensp") %></figcaption></div>
                        </a>
                        <div style="position: absolute; left: 50%; top: 90%; transform: translate(-50%, -50%);">
                            <span style="color: #27CF2D;"><b><%#Eval("dongia") %> VNĐ</b></span><br>
                            <input type="button" value="Mua ngay" id='<%#Eval("masp") %>' class="buy">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <div id="sotrang">
                <asp:Label ID="Label3" runat="server" Text="Trang"></asp:Label>
                <asp:DataPager ID="DataPager1" PagedControlID="ListView1" PageSize="9" runat="server">
                    <Fields>
                        <asp:NumericPagerField ButtonType="Button" />
                    </Fields>
                </asp:DataPager>
            </div>
        </div>
    </div>
    <link href="css/index.css" rel="stylesheet" />
    <script src="js/index.js"></script>
    <script src="js/carousel.js"></script>
</asp:Content>
