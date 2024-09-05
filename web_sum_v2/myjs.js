$(document).ready(function () {
	function send_data() {
		//code gửi POST ở đây
		$.post("api.aspx",
			{
				so1: $('#txt_so1').val(),
				so2: $('#txt_so2').val(),
				thue: $('#txt_thue').val()
			},
			function (data, status) {
				//alert("Data: " + data + "\nStatus: " + status);
				var kq = '';
				if (data.indexOf('Có lỗi') >= 0) {
					//có lỗi thật
					kq = "<span class='maudo'>"+data+"</span>";
				} else {
					kq = "Tổng thu nhập, áp thuế " + $('#txt_thue').val() + "%</span> là <b class='maudo'>" + data + "</b>";
				}
				$('#ketqua').html(kq);
			});
	}

	//khi bấm nút gửi thì gửi dữ liệu lên
	$("#nut_gui").click(function () {
		send_data();
	});
});