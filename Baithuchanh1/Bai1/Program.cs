using System;
using System.Data;
using Microsoft.VisualBasic;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Nhap vao thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So ngay trong thang la: ");
            Console.WriteLine(DateTime.DaysInMonth(nam,thang));

        }


    }
}

