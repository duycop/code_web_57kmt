using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TinhThueVAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            lib_toan.Tong tong;         //khai báo đối tượng
            tong = new lib_toan.Tong();  //cấp phát đối tượng
            tong.a = a;                 //gán input cho đối tượng
            tong.b = b;                 //gán input cho đối tượng
            tong.tinh_tong();           //gọi 1 method of đối tượng

            lbl_KQ.Text = $"Tổng thu nhập, áp thuế {tong.thue * 100}% là {tong.sum}";
        }
    }
}
