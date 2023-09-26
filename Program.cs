using System;
using System.Data;
using Microsoft.VisualBasic;
namespace newApp
{
    class Program
    {       
        public class NhanVien{
            protected string name { get; set; }
            protected DateTime date { get; set; }
            protected int salary { get; set; }
            public int getSalary(){
                return this.salary;
            } 
            public virtual void Nhap(){
                this.name = Console.ReadLine() ?? "";
                this.date = DateTime.Now;
            }
            public void Xuat(){
                Console.WriteLine("Ten nhan vien: {0}",this.name);
                Console.WriteLine("Ngay sinh: {0}",this.date);
                Console.WriteLine("Luong: {0}",this.salary);
            }
            
        }
        public class NhanVienVanPhong : NhanVien{
            int dayWorks {get;set;}
            public override void Nhap(){
                base.Nhap();
                this.dayWorks = Convert.ToInt32(Console.ReadLine());
                this.salary = dayWorks * 100000;
            }
        }
        public class NhanVienSanXuat : NhanVien{
            int defaultSalary {get;set;}
            int products {get;set;}
            public override void Nhap(){
                base.Nhap();
                this.defaultSalary = Convert.ToInt32(Console.ReadLine());
                this.products = Convert.ToInt32(Console.ReadLine());
                this.salary = defaultSalary + products * 5000;
            }
        }
        static void Main(string[] args)
        {   
            int n = Convert.ToInt32(Console.ReadLine());
            NhanVien[] arr = new NhanVien[100];
            for(int i = 0;i < n; i++){
                Console.WriteLine("1.Nhan vien san xuat");
                Console.WriteLine("2.Nhan vien van phong");
                int lc = Convert.ToInt32(Console.ReadLine());
                if(lc == 1){
                    arr[i] = new NhanVienSanXuat();
                }
                else {
                    arr[i] = new NhanVienVanPhong();
                }
                arr[i].Nhap();
            }
            for(int i = 0;i < n; i++){
                arr[i].Xuat();
            }    
            Console.WriteLine("Tong luong cong ty phai tra: ");
            int sum = 0;
            for(int i = 0;i < n; i++){
                sum += arr[i].getSalary();
            }   
            Console.WriteLine(sum);
            Console.WriteLine("Nhan vien co luong cao nhat: ");
            int max = 0;
            int idx = 0;
            for(int i = 0;i < n; i++){
                if(arr[i].getSalary() > max){
                    max = arr[i].getSalary();
                    idx = i;
                }
            }
           arr[idx].Xuat();

        } 
    }
}
