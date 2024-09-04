using System;
using System.Collections.Generic;
using System.Text;


//nguyên tắc khi xây dựng thư viện DLL
//1. độc lập với nơi sử dụng
//2. ko nhập, ko xuất
//3. nhập qua thuộc tính hoặc qua tham số của hàm
//4. xuất qua thuộc tính hoặc qua return của hàm
namespace lib_toan
{
    public class Tong
    {
        public int a, b;
        public double thue=0.1; //10%
        public double sum { get;private set; }
        public void tinh_tong()
        {
            sum = (a + b)*(1+thue);
        }
    }
}
