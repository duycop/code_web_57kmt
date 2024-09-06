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

-----------------------------------------------
CÁCH ĐƯA WEB LÊN IIS
1. Mở control panel
2. Tìm kiếm 'fe' => chọn 'Turn Windows features on or off'
3. Tìm đến mục '.Net FrameWork 3.5 (Includes .NET 2.0 and 3.0)': tích hết trong đó
4. Tìm đến mục '.Net FrameWork 4.8 Advanced Services': tích hết trong đó
5. Tìm đến mục 'Internet Information Service': tích hết trong đó
6. về windows tìm kiếm IIS => chạy 'Internet Information Services (IIS) Manager'
7. add Website... => mở hộp thoại, điền các thông tin sau:
	- tên : để phân biệt khi có nhiều website
	- Physical path: thư mục chứa web
	- Host name : nhập domain vào
8. xử lý domain:
	- loại fake (ko có thật): edit file c:\WINDOWS\SYSTEM32\Drivers\etc\hosts : thêm dòng '127.0.0.1 57kmt.com'
	- loại thật xịn: mua mất tiền và được hướng dẫn cách trỏ ip về host (cần ip tĩnh)
	- loại thật free, dùng được với ip động: www.duckdns.org
	  + ánh xạ ip wan public tới domain vừa đăng ký, xem ip này từ canyouseeme.org
	  + cần mở port 80,443 trên firewall của máy tính dự định làm máy chủ (host)
	  + mở port 80,443 trên router modem (còn gọi là NAT PORT, hoặc Forward port)
	  + check lại với: canyouseeme.org nếu port 80,443 mở là ok
	  + xem thêm mục instal của www.duckdns.org để biết cách tự động cập nhật ip động vào domain free
9. xử lý thư mục chứa web (Physical path)
   copy những file sau vào:
	- thư mục bin: copy DLL  (dll là kết quả biên dịch từ code c#)
	- ảnh, js, css, html, aspx, ashx
	- web.config
	- global.

   chú ý không copy: *.aspx.cs  => ko copy code
10. đăng ký SSL, để có thể truy cập từ https: 
	sử dụng tool: win-acme
11. Sửa file web.config
-----------------------------------------------
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