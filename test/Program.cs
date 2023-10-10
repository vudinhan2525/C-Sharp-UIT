using System;
using System.Data;
using Microsoft.VisualBasic;
namespace test
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao duong dan thu muc: ");
            string strFile = Console.ReadLine();
            DirectoryInfo src1 = new DirectoryInfo(strFile);
            if(src1.Exists){
                FileInfo[] dirs = src1.GetFiles();
                foreach(FileInfo dir in dirs){
                    Console.WriteLine(dir.Name);
                }
            }
            else{
                Console.WriteLine("Not have this path");
            }
        }
    }
}
