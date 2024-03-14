using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không ?

            //Console.Write(" Nhap vao so nguyen: ");
            //int soNguyen = int.Parse(Console.ReadLine());
            //if (soNguyen % 3 == 0) 
            //{ Console.WriteLine(" So {0} chia het cho 3", soNguyen); } 
            //else
            //{ Console.WriteLine(" So {0} khong chia het cho 3", soNguyen); }
            //Console.ReadKey();




            //Bài 2: Nhập vào số nguyên dương, hiển thị bảng cửu chương từ 1 đến n in ra màn hình
            //Console.Write(" Nhap vao so nguyen duong: ");
            //uint soNguyenDuong = uint.Parse(Console.ReadLine());

            //for(uint i =1; i <= soNguyenDuong; i++)
            //{
            //    Console.WriteLine("--------------------------------------------------------------");
            //    Console.WriteLine("Bang cuu chuong "+ i);

            //    for(uint j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}",i,j, i*j);
            //    }    
            //}
            //Console.ReadKey();



            //Bài 3: Nhập số nguyên dương n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình.

            //Console.Write(" Nhap vao so nguyen duong: ");
            //uint soNguyenDuong = uint.Parse(Console.ReadLine());
            //double tong = 0;  // phải sử dụng double để không vượt miền giá trị
            //for ( uint i = 1; i<= soNguyenDuong; i++)
            //{
            //    double giaiThua = 1;
            //    for( uint j=1; j<=i; j++)
            //    {
            //        giaiThua = giaiThua * j;
            //    }
            //    tong = tong+ giaiThua;
            //}
            //Console.WriteLine("Tong giai thua tu 1 den {0} la: {1}",soNguyenDuong,tong);
            //Console.ReadKey();



            //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính chương hay không ?

            //Console.Write(" Nhap vao so nguyen: ");
            //int soNguyen = int.Parse(Console.ReadLine());
            //if(Math.Sqrt(soNguyen)* Math.Sqrt(soNguyen) == soNguyen)
            //{
            //    Console.WriteLine("So {0} la so chinh phuong", soNguyen);
            //} 
            //else
            //{
            //    Console.WriteLine("So {0} khong phai la so chinh phuong", soNguyen);
            //}
            //Console.ReadKey();


            //Bài 5: Viết chương trình nhập vào tháng bất kì từ bàn phím, hiển thị số ngày có trong tháng đó ra màn hình

            //Console.Write(" Nhap vao thang bat ki trong nam: Thang ");
            //int thang = int.Parse(Console.ReadLine());
            //switch (thang)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine(" Thang {0} co 31 ngay",thang);
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine(" Thang {0} co 30 ngay", thang);
            //        break;
            //    case 2:
            //        Console.WriteLine(" Thang {0} co 28 ngay hoac 29", thang);
            //        break;
            //    default:
            //            Console.WriteLine(" Khong co thang {0}",thang);
            //        break;
            //}
            //Console.ReadKey();



            //Bài 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức:
            // S= 1+2^2+3^3+...+n^n

            //Console.Write(" Nhap vao so nguyen:");
            //int soNguyen = int.Parse(Console.ReadLine());
            //double S = 0;
            //int i = 1;
            //while(i <=soNguyen)
            //{
            //    S = S + Math.Pow(i, i);
            //    i++;
            //}
            //Console.WriteLine(" Tong S la: " + S);
            //Console.ReadKey();


            //Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình
            //Console.Write(" Nhap vao so nguyen:");
            //int soNguyen = int.Parse(Console.ReadLine());
            //int tong = 0;

            //for(int i = 1; i<=soNguyen; i++)
            //{
            //if (i%2==0) continue;
            //    tong = tong + i;
            //}
            //Console.WriteLine("Tong so le la " + tong);
            //Console.ReadKey();

            //Bài 8: Nhập vào các số nguyên dương n, hiển thị màn hình các số nguyên tố từ 1 đến n (Chưa làm được)


            //Bài 9: Viết chương trình vẽ tam giác kí tự bất kì xuôi và ngược.

            //Console.Write(" Nhap vao hang: ");
            //int soHang = int.Parse(Console.ReadLine());
            //Console.Write(" Nhap ki tu: ");
            //string kiTu = Console.ReadLine();
            //// Tam giác xuôi
            //for(int i=1; i<=soHang; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(kiTu);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------------------------------------");
            //// Tam giác ngược
            // for(int i=soHang; i>0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(kiTu);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //Bài 10: Nhập số nguyên dương n tính toán và hiển thị dãy Fibonacci ra màn hình

            Console.Write(" Nhap vao so nguyen duong: ");
            uint soNguyenDuong = uint.Parse(Console.ReadLine());
            uint so1 = 0, so2 = 1, so3;
            Console.WriteLine(" Day fibo voi {0} phan tu", soNguyenDuong);
            Console.Write("{0} {1} ",so1,so2);
            for (uint i = 2; i < soNguyenDuong; i++)
            {
                so3 = so1 + so2;
                Console.Write(so3 + " ");
                so1 = so2;
                so2 = so3;
            }
            Console.ReadKey();







        }
    }
}
 