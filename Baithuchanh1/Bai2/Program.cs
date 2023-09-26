using System;
using System.Data;
using Microsoft.VisualBasic;
namespace Bai2
{
    class Program
    {   
        static bool CheckPrime(int x){
            for(int i = 2;i <= Math.Sqrt(x); i++){
                if(x % i == 0)  return false;
            }
            return x >= 2;
        }
        static bool CheckCp(int x){
            return Math.Sqrt(x) * Math.Sqrt(x) == x;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum1 = 0;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if(arr[i] % 2 == 1){
                    sum1 += arr[i];
                }
            }
            Console.WriteLine("Tong cac so le trong mang la: {0}",sum1);
            for(int i = 0;i < n;i++){
                if(CheckPrime(arr[i])){
                    cnt++;
                }
            }
            Console.WriteLine("Tong cac so nguyen to trong mang la: {0}",cnt);
            int min = 1000000;
            for(int i = 0;i < n; i++){
                if(CheckCp(arr[i])){
                    if(arr[i] < min){
                        min = arr[i];
                    }
                }
            }
            if(min == 1000000) min = -1;
            Console.WriteLine("So chinh phuong nho nhat la: {0}",min);

        }


    }
}

