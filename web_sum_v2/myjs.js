$(document).ready(function () {
	function send_data() {
		var gui_di = {
			so1: $('#txt_so1').val(),
			so2: $('#txt_so2').val(),
			thue: $('#txt_thue').val()
		};

		if (isNaN(gui_di.so1)) {
			$('#ketqua').html('Số 1 chưa nhập đúng anh ơi!');
			$('#txt_so1').focus();
			return;
		}
		if (isNaN(gui_di.so2)) {
			$('#ketqua').html('Số 2 chưa nhập đúng anh ơi!');
			$('#txt_so2').focus();
			return;
		}
		if (isNaN(gui_di.thue)) {
			$('#ketqua').html('Thuế chưa nhập đúng anh ơi!');
			$('#txt_thue').focus();
			return;
		}
		
		//code gửi POST ở đây
		$.post("api.aspx", gui_di,
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