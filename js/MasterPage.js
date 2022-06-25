function notLogin() {
    var s = `<a href="dangky.aspx" style="float: right; color: white; margin: 5px; margin-top: 136px">Đăng ký</a>
		      <a href="dangnhap.aspx" style="float: right; color: white; margin: 5px; margin-top: 136px">Đăng nhập</a>`;
    document.getElementById("member").innerHTML = s;
}

function Logined(name) {
    s = `<a style="float: right; color: white; margin: 5px; margin-top: 139px;" href="javascript:void(0);">
		    <div class="dropdown">Xin chào <span>`+ name + `</span>
			    <div class="dropdown-content">
				    <p><a href="giohang.aspx" style="color:white">Xem giỏ hàng<i class="fa fa-cart-plus"> </i></a></p>
				    <p><a href="javascript:void(0);" onClick="signout()" style="color:white">Đăng xuất<i class="fa fa-sign-out"></i></a></p>
                </div>
		    </div>
		 </a>`;
    document.getElementById("member").innerHTML = s;
}

function CheckLogin() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/CheckLogin",
        data: "",
        contentType: "application/json",
        datatype: "json"
    }).done(function (response) {
        if (response.d == "")
            notLogin();
        else
            Logined(response.d)
    }).fail(function (response) {
        alert('Lỗi phản hồi: CheckLogin');
        notLogin();
    })
}
function signout() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/Logout",
        data: "",
        contentType: "application/json",
        datatype: "json"
    }).done(function (response) {
        if (response.d == true)
            window.location.href = 'index.aspx';
        else
            alert("Lỗi đăng xuất");
    }).fail(function (response) {
        alert('Lỗi phản hồi: signout')
    })
}

function buy(id) {
    dataValue = `{masp:`+id+`, sl: 1}`;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/Buy",
        data: dataValue,
        contentType: "application/json",
        datatype: "json"
    }).done(function (response) {
        if (response.d == 0)
            alert("Đã thêm vào giỏ hàng");
        else if (response.d == 1)
            alert("Lỗi không thể thêm vào giỏ hàng");
        else
            alert("Vui lòng đăng nhập để mua hàng");
    }).fail(function (response) {
        alert('Lỗi phản hồi: buy')
    })
}

$(document).ready(function () {
    $('.buy').click(function () {
        id = $(this).attr('id');
        buy(id);
    })


    if ($(location).attr('pathname') == "/dangnhap.aspx" || $(location).attr('pathname') == "/dangky.aspx")
        return;
    else
        CheckLogin();
});