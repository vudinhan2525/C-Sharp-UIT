using System;
using System.Data;
using Microsoft.VisualBasic;
using System.Linq;
namespace Bai4
{
    class Program
    {
        static int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        public class Phanso
        {
            int x { get; set; }
            int y { get; set; }
            public void Nhap()
            {
                this.x = Convert.ToInt32(Console.ReadLine());
                this.y = Convert.ToInt32(Console.ReadLine());
            }
            public void Rutgon()
            {
                int r = gcd(x, y);
                this.x /= r;
                this.y /= r;
            }
            public void Xuat(){
                Console.WriteLine("{0}/{1}",this.x,this.y);
            }
            public static Phanso operator +(Phanso a,Phanso b){
                Phanso c = new Phanso();
                c.x = a.x * b.y + a.y * b.x;
                c.y = a.y * b.y;
                c.Rutgon();
                return c;
            }
            public static Phanso operator -(Phanso a,Phanso b){
                Phanso c = new Phanso();
                c.x = a.x * b.y - a.y * b.x;
                c.y = a.y * b.y;
                c.Rutgon();
                return c;
            }
            public static Phanso operator *(Phanso a,Phanso b){
                Phanso c = new Phanso();
                c.x = a.x * b.x;
                c.y = a.y * b.y;
                c.Rutgon();
                return c;
            }
            public static Phanso operator /(Phanso a,Phanso b){
                Phanso c = new Phanso();
                c.x = a.x * b.y;
                c.y = a.y * b.x;
                c.Rutgon();
                return c;
            }
        }
        static void Main(string[] args)
        {   
            Phanso a = new Phanso();
            a.Nhap();
            Phanso b = new Phanso();
            b.Nhap();
            Phanso c = a / b;
            c.Xuat();
        }


    }
}

