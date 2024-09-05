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


---------
BÀI TẬP VỀ NHÀ:
Mỗi sv tạo 1 solution:
 - project console1: xử lý bài toán đơn giản nào đó
 - chuyển phần xử lý sang DLL
 - project console2: dùng DLL cho kq như console1
 - project web v1: kéo thả từ toolbox => design laypout
	code behide: c# lấy được input trên web-form
	dùng DLL để xử lý input => kq
	thay đổi thuộc tính của layout từ C#
 - project web v2: layout thuần html+css 
   code js: lấy data trên html input => ajax post server (api.aspx)
   code c# trong api.aspx:
	+ lấy được data gửi lên => convert, check lỗi....
	+ dùng DLL để ra KQ
	+ bọc kq vào format JSON, gửi lại client
		DÙNG DLL hỗ trợ việc tạo json
		keyword: json net
   code js: nhận về data ở format JSON
    + thuận lợi dễ dành bóc tách các thuộc tính
	+ vd: json = JSON.parse(data);
	     if(json.ok){ dst1; json.data->hiển thị } else dst2;

sv sử dụng VS2022
link github: public
gửi link github