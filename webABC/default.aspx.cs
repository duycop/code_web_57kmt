using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webABC
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ok = 0;
            try
            {
                int a, b;
                a = int.Parse(TextBox1.Text);
                ok = 1;
                b = int.Parse(TextBox2.Text);
                ok = 2;
                double thue = double.Parse(TextBox3.Text) / 100.0;
                ok = 3;

                lib_toan.Tong tong;         //khai báo đối tượng
                tong = new lib_toan.Tong();  //cấp phát đối tượng
                tong.a = a;                 //gán input cho đối tượng
                tong.b = b;                 //gán input cho đối tượng
                tong.thue = thue;
                tong.tinh_tong();           //gọi 1 method of đối tượng

                ketqua.InnerHtml = $"Tổng thu nhập, áp <span title = \"Thuế VAT={tong.thue*100}%\">thuế {tong.thue * 100}%</span> là <b class='maudo'>{tong.sum}</b>";
            }
            catch (Exception ex)
            {
                if (ok == 0)
                {
                    ketqua.InnerHtml = $"Có lỗi khi nhập số thứ nhất";
                    TextBox1.Focus();
                }
                else if (ok == 1)
                {
                    ketqua.InnerHtml = $"Có lỗi khi nhập số thứ hai";
                    TextBox2.Focus();
                }
                else if (ok == 2)
                {
                    ketqua.InnerHtml = $"Có lỗi khi nhập thuế";
                    TextBox3.Focus();
                }
                else
                    ketqua.InnerHtml = $"Có lỗi gì đó: " + ex.Message;
            }
        }
    }
}