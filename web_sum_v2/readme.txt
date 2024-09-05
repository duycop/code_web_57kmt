v1: gửi lên 555bytes, nhận về 1.4Kb

web sum v2:
mục tiêu:
tải nhanh
post bé : gửi lên dưới 100byte
nhận lại bé tí: dưới 200byte
hiển thị giống v1
---
cách làm:
1. tạo file index.html, layout mong muốn
2. tạo 1 myjs.js
3. kéo jquery.min.js về
4. nhúng 2 file js vào index.html
5. code myjs.js theo cú pháp của JQuery
   đăng ký sự kiện click of nút gửi 
   gửi POST các dữ liệu trên các input textbox
   gửi tới api.aspx 
   đợi api xử lý phía server, chờ nó Response
   khi đc data Response: chính là từ c#: this.Response.Write(kq);
   tiền xử lý data (nếu cần): thêm html
   đẩy vào 1 tag html nào đó: thông qua id. 
   vd: $('#ketqua').html(kq);

6. tạo mới 1 web form: api
   xoá sạch mọi dòng, trừ dòng 1 của api.aspx
7. code trong event Page_load of api.aspx.cs
	this.Request["so1"]  => trả về dữ liệu gửi lên: so1
	sử dụng DLL lib_toán => kq
	gửi lại: this.Response.Write(kq);