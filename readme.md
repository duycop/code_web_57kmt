# Lập trình web với asp.net

1. **Project console app:** 

   c# windows console

   console app (.Net framework)

   code c# tính toán trực tiếp: [57kmt](57kmt)

   khi build tạo ra exe

2. **Thư viện liên kết động => tạo ra DLL**

   c# windows library

   class library (.Net framework) 

   tách phần tính toán thành class

   Chú ý: DLL PHẢI LUÔNG TUÂN THEO NGUYÊN TẮC **HOẠT ĐỘNG ĐỘC LẬP VỚI NƠI DÙNG**

   khi build tạo ra .dll  (dll == dynamic link library)

   view [code dll](lib_toan)

3. **Console app sử dụng DLL**

   c# windows console
  
   console app (.net framework) 

   add references tới project lib_toan

   thiết kế giao diện form

   phần xử lý đẩy cho DLL xử lý 

   [xem code dùng dll](Sum_use_DLL)

4. **Windows form App: dùng DLL**

   C# Windows Desktop

   Windows form application (.Net framework) 

   Add reference tới project lib_toán

   Thiết kế giao diện (cần thẩm mĩ)

   Code xử ký y sì như Sum_use_DLL

   Biên dịch ra exe

   Xem code [win form use DLL](TinhThueVAT)


5. **WEB FORM APPLICATION**

   C# windows Web

   Asp.net Webform Application (.Net fw)

   Tạo giao diện (cần hiểu html+css)

   khi biên dịch ra DLL

   chạy test qua IIS Express

   biên dịch ra exe

   code web [tại đây](webABC)

6. **WEB FORM ~ API**

   Sử dụng index.html+css làm layout (KHÔNG kéo thả từ toolbox các đối tượng asp.net)

   Sử dụng thư viện javascript: **jquery.min.js**

   Viết thêm code js trong file myjs:

      - Sử dụng jquery để post dữ liệu lên api.aspx : kỹ thuật này gọi là **ajax**

      - Chờ phản hồi dữ liệu từ api

      - Nhận được phản hồi thì tiền xử lý nó, rồi hiển thị ra trang html tại 1 tag nào đó

   add tham chiếu đến project **DLL: Lib_toan**
   
   code C#: add web form, đặt tên là api  => sẽ tạo ra api.aspx (nơi tạo giao diện của bài 5), và api.aspx.cs (code behide chứa code c#)

   viết code trong sự kiện Page_Load của api.aspx.cs

   để lấy chuỗi trong biến 'so1' gửi lên ở dạng POST, dùng lệnh:  **String so1 = this.Request.Form["so1"];**
   
   để lấy chuỗi trong biến 'so1' gửi lên ở dạng GET, dùng lệnh:  String so1 = this.Request.QueryString["so1"];

   để lấy chuỗi trong biến 'so1' gửi lên ở trong COOKIE, dùng lệnh:  String so1 = this.Request.Cookies["so1"].Value;

   để lấy chuỗi trong biến 'so1' CÓ SẴN TRÊN SERVER VÀ Ở TRONG SESSION, dùng lệnh:  String so1 = (String)this.Session["so1"];

   Lấy hết các input cần thiết, sử dụng DLL để xử lý => nhận được kết quả (kq)

   Gửi lại client kết quả đã xử lý bằng lệnh: **this.Response.Write(kq);**

   code web v2 [xem code](web_sum_v2)
   
   
