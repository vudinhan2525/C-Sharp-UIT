using System;
using System.Data;
using Microsoft.VisualBasic;
using System.Linq;
namespace Bai3
{
    class Program
    {   
        static bool CheckPrime(int x){
            for(int i = 2;i <= Math.Sqrt(x); i++){
                if(x % i == 0)  return false;
            }
            return x >= 2;
        }
        static void Main(string[] args)
        {   
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] arr = new int[n,m];
            var r = new Random();
            for(int i = 0;i < n; i++){
                for(int j = 0;j < m; j++){
                    arr[i,j] = r.Next() % 1000;
                }
            }

            // Cau a,b
            int max = 0;
            int min = Int32.MaxValue;
            for(int i = 0;i < n; i++){
                for(int j = 0;j < m; j++){
                    Console.Write("{0} ",arr[i,j]);
                    min = Math.Min(min,arr[i,j]);
                    max = Math.Max(max,arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Min:{0} , Max:{1}" ,min,max);

            //Cau c
            int maxRow = 0;
            int maxRowIdx = 0;
            for(int i = 0;i < n; i++){
                int sum = 0;
                for(int j = 0;j < m; j++){
                    sum += arr[i,j];
                }
                if(maxRow < sum){
                    maxRow = sum;
                    maxRowIdx = i;
                }
            }
            Console.WriteLine("Dong co tong lon nhat: {0}" ,maxRowIdx);
            //Cau d
            int sumNotPrime = 0;
            for(int i =0;i < n; i++){
                for(int j = 0;j < m; j++){
                    if(!CheckPrime(arr[i,j])){
                        sumNotPrime += arr[i,j];
                    }
                }
            }
            Console.WriteLine("Tong cac so khong phai so nguyen to: {0}" ,sumNotPrime);
            //Cau e
            Console.WriteLine("Nhap vao dong can xoa");
            int rowDeleteIdx = Convert.ToInt32(Console.ReadLine()) - 1;
            for(int i =0;i < n; i++){
                for(int j = 0;j < m; j++){
                    if(i == n - 1)  {
                        arr[i,j] = 0;
                        continue;
                    }
                    if(i >= rowDeleteIdx){
                        arr[i,j] = arr[i + 1,j];
                    }
                    
                }
            }
            n--;
            for(int i = 0;i < n; i++){
                for(int j = 0;j < m; j++){
                    Console.Write("{0} ",arr[i,j]);
                }
                Console.WriteLine();
            }
            //Cau f
            Console.WriteLine("Mang sau khi xoa di cot chua phan tu lon nhat:");
            int maxEle = 0;
            int maxEleColIdx = -1;
            for(int i = 0;i < n; i++){
                for(int j = 0;j < m; j++){
                    if(arr[i,j] > maxEle){
                        maxEle = arr[i,j];
                        maxEleColIdx = j; 
                    }
                }
            }
            for(int j = 0;j < m;j++){
                for(int i = 0;i < n;i++){
                    if(j == m - 1) continue; 
                    if(j >= maxEleColIdx){
                        arr[i,j] = arr[i,j + 1];
                    }
                }
            }
            m--;
            for(int i = 0;i < n; i++){
                for(int j = 0;j < m; j++){
                    Console.Write("{0} ",arr[i,j]);
                }
                Console.WriteLine();
            }
        }


    }
}

