using ConsoleApp1.assignments;
using ConsoleApp1.session1;

public class Program
{
    public static void Main(string[] args)
    {
        //int x = 10;
        //double y = 3.14;
        //Console.WriteLine("Hello world: " + x);
        //string s = "T2204M";

        //int[] ns = new int[3];
        //ns[0] = 15;
        //ns[1] = 20;
        //ns[2] = 25;

        //foreach (int n in ns)
        //{
        //    // n
        //}

        //for (int i = 0; i < ns.Length; i++)
        //{
        //    // n[i]
        //}

        ////INPUT AND OUTPUT
        //string input = Console.ReadLine(); // scan
        //int num = Convert.ToInt32(input);
        //Console.WriteLine("num = " + num);

        ////CLASS AND OBJECT
        //Human h = new Human();
        //h.name = "Nguyen Van An";
        //h.Run();


        // ---------------- TEST ASSIGNMENT 1 ----------------
        Fraction f1 = new Fraction();
        Console.WriteLine("Phan so f1:");
        Console.WriteLine("Nhap tu so: ");
        f1.TuSo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap mau so: ");
        f1.MauSo = Convert.ToInt32(Console.ReadLine());

        f1.InPhanSo();
        f1.RutGon();
        f1.InPhanSo();

        Fraction f2= new Fraction();
        Console.WriteLine("Phan so f1:");
        Console.WriteLine("Nhap tu so: ");
        f2.TuSo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap mau so: ");
        f2.MauSo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ket qua phep cong: ");
        f1.add(f2).InPhanSo();
        Console.WriteLine("Ket qua phep tru: ");
        f1.subtract(f2).InPhanSo();
        Console.WriteLine("Ket qua phep nhan: ");
        f1.multiply(f2).InPhanSo();
        Console.WriteLine("Ket qua phep chia: ");
        f1.divide(f2).InPhanSo();


        //This is to test git changes
    }
}
