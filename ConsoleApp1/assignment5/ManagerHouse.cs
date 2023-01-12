using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class ManagerHouse
    {
        private List<HaNoiHouse> houseList = new List<HaNoiHouse>();
        public List<HaNoiHouse> HouseList
        {
            get { return houseList; }
            set { houseList = value; }
        }

        //Phuong thuc hien thi thong tin cua tat ca cac nha
        public void HienThi()
        {
            for (int i = 0; i < HouseList.Count; i++)
            {
                Console.WriteLine($"Thong tin cua nha thu {i + 1}");
                HouseList[i].Display();
            }
        }
        //Phuong thuc sap xep theo dia chi
        public void SapXep() 
        {
            HouseList.Sort((x, y) => x.DiaChi.CompareTo(y.DiaChi));
        }
        //Phuong thuc tim kiem theo dia chi
        public List<HaNoiHouse> TimDiaChi(string diaChi)
        {
            List<HaNoiHouse> result = new List<HaNoiHouse>();
            foreach (HaNoiHouse h in HouseList)
            {
                if (h.DiaChi.Contains(diaChi)) result.Add(h);
            }
            return result;
        }

        //Lam menu
        public void ShowMenu() //This ShowMenu() will be call in Program.cs
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Cac lua chon trong menu:");
            Console.WriteLine("1) Nhap thong tin n ngoi nha o Ha Noi");
            Console.WriteLine("2) Hien thi thong tin cua n ngoi nha do");
            Console.WriteLine("3) Sap xep truong dia chi va hien thi thong tin sau khi sap xep");
            Console.WriteLine("4) Tim kiem nha theo dia chi nhap vao");
            Console.WriteLine("5) Thoat");
            Console.Write("\r\nChon viec: ");

            switch (Console.ReadLine())
            {
                case "1":
                    HaNoiHouse hnh = new HaNoiHouse();
                    hnh.Input();
                    HouseList.Add(hnh);
                    return true;
                case "2":
                    HienThi();
                    Console.ReadKey();
                    return true;
                case "3":
                    SapXep();
                    HienThi();
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.WriteLine("Nhap dia chi can tim kiem: ");
                    List<HaNoiHouse> result = TimDiaChi(Console.ReadLine());
                    if (result == null)
                    {
                        Console.WriteLine("Khong tim duoc ket qua nao");
                    } else
                    {
                        Console.WriteLine($"Co {result.Count} ket qua");
                        for (int i = 0; i < result.Count; i++)
                        {
                            Console.WriteLine($"Thong tin cua nha thu {i + 1}");
                            result[i].Display();
                        }
                    }
                    Console.ReadKey();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
    }
}
