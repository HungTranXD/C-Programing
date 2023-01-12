using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.cm
{
    internal class House : IHouse
    {
        //Auto-implemented properties
        public string SoNha { get; set; }
        public string DiaChi { get; set; }
        public string LoaiNha { get; set; }

        //Constructors
        public House() { }

        public House(string soNha, string diaChi, string loaiNha)
        {
            SoNha = soNha;
            DiaChi = diaChi;
            LoaiNha = loaiNha;
        }

        //Override methods of IHouse:
        public virtual void Input()
        {
            Console.Write("Nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap loai nha: ");
            LoaiNha = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("Thong tin cua nha: ");
            Console.WriteLine($"- So nha: {SoNha}");
            Console.WriteLine($"- Dia chi: {DiaChi}");
            Console.WriteLine($"- Loai nha: {LoaiNha}");
        }
    }
}
