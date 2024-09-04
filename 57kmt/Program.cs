using System;
using System.Collections.Generic;
using System.Text;

namespace _57kmt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PHAN MEM TINH TONG 2 SO NGUYEN");
            int a, b;
            Console.Write("Nhap so a:"); a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b:"); b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("tong={0}", sum);
        }
    }
}
