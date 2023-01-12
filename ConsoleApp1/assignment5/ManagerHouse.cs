using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class ManagerHouse
    {
        public static List<HaNoiHouse> houseList = new List<HaNoiHouse>();


        public static void RunMenu() //This RunMenu() will be call in Program.cs
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
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
                    houseList.Add(hnh);
                    return true;
                case "2":
                    
                    return true;
                case "3":

                    return true;
                case "4":

                    return true;
                case "5":

                    return false;
                default:
                    return true;
            }
        }
    }
}
