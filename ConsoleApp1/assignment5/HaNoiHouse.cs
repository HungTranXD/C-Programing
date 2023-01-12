using house.cm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class HaNoiHouse : House
    {
        //Properties
        public string TenQuan { get; set; }

        //Constructors
        public HaNoiHouse() { }
        public HaNoiHouse(string soNha, string diaChi, string loaiNha, string tenQuan) :base(soNha, diaChi, loaiNha)
        {
            TenQuan = tenQuan;
        }

        //Override methods
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap ten quan: ");
            TenQuan = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"- Ten quan: {TenQuan}");
        }

        

    }
}
