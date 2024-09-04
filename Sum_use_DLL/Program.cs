using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_use_DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PHAN MEM TINH TONG 2 SO NGUYEN");
            int a, b;
            Console.Write("Nhap so a:"); a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b:"); b = int.Parse(Console.ReadLine());

            lib_toan.Tong tong;         //khai báo đối tượng
            tong= new lib_toan.Tong();  //cấp phát đối tượng
            tong.a = a;                 //gán input cho đối tượng
            tong.b = b;                 //gán input cho đối tượng
            tong.tinh_tong();           //gọi 1 method of đối tượng
            double sum = tong.sum;         //lấy 1 output trong đối tượng

            Console.WriteLine("tong+ thue={0}", sum); //dùng để display
        }
    }
}
