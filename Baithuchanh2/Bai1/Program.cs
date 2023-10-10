using System;
using System.Data;
using Microsoft.VisualBasic;
namespace Baithuchanh2_1
{   
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao duong dan thu muc: ");
            string strFile = Console.ReadLine();
            DirectoryInfo src1 = new DirectoryInfo(strFile);
            if(src1.Exists){
                DirectoryInfo[] dirs = src1.GetDirectories();
                FileInfo[] files = src1.GetFiles();
                foreach(DirectoryInfo dir in dirs){
                    Console.WriteLine(dir.CreationTime + "\t\t <DIR> \t\t" + dir.Name);
                }
                foreach(FileInfo file in files){
                    Console.WriteLine(file.CreationTime + "\t\t "  + file.Length + " \t\t" + file.Name);
                }
            }
            else{
                Console.WriteLine("Not have this path");
            }
        }
    }
}