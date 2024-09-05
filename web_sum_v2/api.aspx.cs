using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_sum_v2
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //code c# để nhận dữ liệu POST gửi lên
            int ok = 0;
            try
            {
                int a, b;
                a = int.Parse(this.Request["so1"]);
                ok = 1;
                b = int.Parse(this.Request["so2"]);
                ok = 2;
                double thue = double.Parse(this.Request["thue"]) / 100.0;
                ok = 3;

                lib_toan.Tong tong;         //khai báo đối tượng
                tong = new lib_toan.Tong();  //cấp phát đối tượng
                tong.a = a;                 //gán input cho đối tượng
                tong.b = b;                 //gán input cho đối tượng
                tong.thue = thue;
                tong.tinh_tong();           //gọi 1 method of đối tượng

                //ketqua.InnerHtml = $"Tổng thu nhập, áp <span title = \"Thuế VAT={tong.thue * 100}%\">thuế {tong.thue * 100}%</span> là <b class='maudo'>{tong.sum}</b>";
                //string ketqua = $"Tổng thu nhập, áp <span title = \"Thuế VAT={tong.thue * 100}%\">thuế {tong.thue * 100}%</span> là <b class='maudo'>{tong.sum}</b>";
                //trả về 217 bytes, vẫn to,  cần bé hơn
                string ketqua = $"{tong.sum}";
                this.Response.Write(ketqua);
            }
            catch (Exception ex)
            {
                string kq;
                if (ok == 0)
                {
                    kq = $"Có lỗi khi nhập số thứ nhất";
                }
                else if (ok == 1)
                {
                    kq = $"Có lỗi khi nhập số thứ hai";
                }
                else if (ok == 2)
                {
                    kq = $"Có lỗi khi nhập thuế";
                }
                else
                {
                    kq = $"Có lỗi gì đó: " + ex.Message;
                }
                this.Response.Write(kq);
            }
        }
    }
}