using ConsoleApp1.assignment2;
using ConsoleApp1.assignments;
using ConsoleApp1.assignmnet3;
using ConsoleApp1.session1;
using ConsoleApp1.session2;
using ConsoleApp1.session3;

public class Program
{
    public static void Main(string[] args)
    {
        //Car car = new Car(); //không cấp phát ô nhớ
        //Car car2 = new Car() { Brand = "Toyota", Type = "Sedan" }; //có ô nhớ

        //Console.WriteLine(car.parts[0]); // Cách 1: Thông thường
        //Console.WriteLine(car[0]); //Cách 2: Sử dụng Indexer

        ////car[3] = "Doors"; -> lỗi vì chưa có ô nhớ nên không chạy hàm set được
        //car.parts.Add("Doors");

        //try
        //{
        //    int x = 10;
        //    int y = 0;
        //    if (y == 0) throw new Exception("y can not be zero");
        //    Console.WriteLine("x / y = ");
        //    int z = x / y;
        //    Console.WriteLine(z);
        //} catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        // ---------------- TEST ASSIGNMENT 3 ----------------
        VietnameseCustomer vnCus1 = new VietnameseCustomer("VN001", "Nguyễn Văn An", DateOnly.FromDateTime(DateTime.Now), 25, VnCusType.SinhHoat);
        Console.WriteLine("Payment 1: " + vnCus1.CalPayment());

        ForeignCustomer frCus1 = new ForeignCustomer("FR001", "John Smith", DateOnly.Parse("2021-01-01"), 200);
        Console.WriteLine("Payment 2: " + frCus1.CalPayment());
    }
    public static void Main2(string[] args) //Session 2
    {
        ////Dog d = new Dog();
        ////d.SetSpecies("Husky");
        ////d.getInfo();

        //Dog d = new Dog("Husky", 21.0);
        //d.Weight = 12;
        //d.Color = "Black";
        //Console.WriteLine(d.Weight);
        //Console.WriteLine(d.Color);

        ////Su dung Array thuong
        //Dog[] dogs = new Dog[10];
        //for (int i = 0 ; i < dogs.Length; i++)
        //{
        //    dogs[i] = new Dog();
        //}
        //foreach (Dog o in dogs)
        //{
        //    o.Color = "Black";
        //}
        
        ////Su dung List
        //List<Dog> dogList = new List<Dog>();
        //dogList.Add(new Dog());
        //Console.WriteLine(dogList.Count);



        // ---------------- TEST ASSIGNMENT 2 ----------------
        PhoneBook pb = new PhoneBook();

        pb.InsertPhone("John Smith", "111111111");
        pb.InsertPhone("John Smith", "111112222");
        pb.InsertPhone("John Smith", "111113333");
        pb.InsertPhone("Rick Hammer", "222222222");
        pb.InsertPhone("Emma Jane", "33333333");
        pb.InsertPhone("Hardy Watson", "444444444");
        pb.InsertPhone("Sherlock Home", "55555555");
        pb.InsertPhone("Sherlock Home", "55556666");
        pb.InsertPhone("Sherlock Home", "55557777");

        pb.RemovePhone("Hardy Watson");
        pb.UpdatePhone("John Smith", "111112222", "0000000000");
        pb.Sort();

        foreach (PhoneNumber pn in pb.PhoneList)
        {
            foreach (string n in pn.Numbers)
            {
                Console.WriteLine(pn.Name + " - " + n);
            }
            
        }
    }
    public static void Main1(string[] args) //Session 1
    {
        int x = 10;
        double y = 3.14;
        Console.WriteLine("Hello world: " + x);
        string s = "T2204M";

        int[] ns = new int[3];
        ns[0] = 15;
        ns[1] = 20;
        ns[2] = 25;

        foreach (int n in ns)
        {
            // n
        }

        for (int i = 0; i < ns.Length; i++)
        {
            // n[i]
        }

        //INPUT AND OUTPUT
        string input = Console.ReadLine(); // scan
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num);

        //CLASS AND OBJECT
        Human h = new Human();
        h.name = "Nguyen Van An";
        h.Run();


        // ---------------- TEST ASSIGNMENT 1 ----------------
        //Fraction f1 = new Fraction();
        //Console.WriteLine("Phan so f1:");
        //Console.WriteLine("Nhap tu so: ");
        //f1.TuSo = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Nhap mau so: ");
        //f1.MauSo = Convert.ToInt32(Console.ReadLine());

        //f1.InPhanSo();
        //f1.RutGon();
        //f1.InPhanSo();

        //Fraction f2= new Fraction();
        //Console.WriteLine("Phan so f1:");
        //Console.WriteLine("Nhap tu so: ");
        //f2.TuSo = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Nhap mau so: ");
        //f2.MauSo = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Ket qua phep cong: ");
        //f1.add(f2).InPhanSo();
        //Console.WriteLine("Ket qua phep tru: ");
        //f1.subtract(f2).InPhanSo();
        //Console.WriteLine("Ket qua phep nhan: ");
        //f1.multiply(f2).InPhanSo();
        //Console.WriteLine("Ket qua phep chia: ");
        //f1.divide(f2).InPhanSo();

    }
}
