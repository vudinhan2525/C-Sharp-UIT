using System;
using System.Data;
namespace newApp
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        public struct MyPoint{
            public int x,y;
            public MyPoint (int p1,int p2){
                x = p1;
                y = p2;
            }
        }
        static void Main(string[] args)
        {
            MyPoint a = new MyPoint(1,2);
            Console.WriteLine("{0},{1}",a.x,a.y);
        }
    }
}
