http://57kmt.duckdns.org

các bước đưa sp web online
1. design+code+run on iis express: ok
2. test trên local iis => làm i sì trên iis máy chủ thật
- enable iis: control panel/fe/iis/checked all
- use iis manager:add website/fill:
   + name (để phân biệt với web khác: only dev see)
   + vật lý path: đường dẫn tới thư mục web
   + hostname: domain  (vd: 57kmt.com)
	fake edit: c:\WINDOWS\SYSTEM32\Drivers\etc\hosts
            127.0.0.1	57kmt.com	
	reg domain xịn: www.duckdns.org (free)
	   	ánh xạ ip wan public tới domain này
		lấy ip qua trang: canyouseeme.org
		nếu ip is dynamic: của nhà chúng ta, dùng máy tính làm máy chủ
                 -> https://www.duckdns.org/install.jsp
3. mở firewall: mở port 80, 443
4. mở port của router (modem): 80, 443
5. reg ssl => https: wacs
6. edit web.config: auto chuyển hướng từ http -> https