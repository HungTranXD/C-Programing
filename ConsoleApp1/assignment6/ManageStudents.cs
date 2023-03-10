using house.hanoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment6
{
    internal class ManageStudents
    {
        private List<Student> studentList = new List<Student>();
        public List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }

        //1. Them sinh vien
        public void AddStudent(Student s)
        {
            StudentList.Add(s);
        }

        //2. Cap nhat thong tin sinh vien boi ID
        public void UpdateStudentByID(string iD)
        {
            foreach (Student s in StudentList)
            {
                if (s.ID.Equals(iD))
                {
                    Console.WriteLine("Thong tin sinh vien tuong ung: ");
                    Console.WriteLine("1) Ten: " + s.Name);
                    Console.WriteLine("2) Gioi tinh: " + s.Gender);
                    Console.WriteLine("3) Tuoi: " + s.Age);
                    Console.WriteLine("4) Diem toan: " + s.PhysicsScore);
                    Console.WriteLine("5) Diem ly: " + s.MathScore);
                    Console.WriteLine("6) Diem hoa: " + s.ChemistryScore);
                    Console.WriteLine("7) Diem trung binh: " + s.AverageScore);
                    Console.WriteLine("8) Hoc luc: " + s.RankedAcademic);
                    Console.Write("\r\nChon thong tin can sua: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Sua ten: ");
                            s.Name = Console.ReadLine();
                            return;
                        case "2":
                            Console.Write("Sua gioi tinh: ");
                            s.Gender = Console.ReadLine();
                            return;
                        case "3":
                            Console.Write("Sua tuoi: ");
                            s.Age = Convert.ToInt32(Console.ReadLine());
                            return;
                        case "4":
                            Console.Write("Sua diem toan: ");
                            s.MathScore = Convert.ToDouble(Console.ReadLine());
                            return;
                        case "5":
                            Console.Write("Sua diem ly: ");
                            s.PhysicsScore = Convert.ToDouble(Console.ReadLine());
                            return;
                        case "6":
                            Console.Write("Sua diem hoa: ");
                            s.ChemistryScore = Convert.ToDouble(Console.ReadLine());
                            return;
                        default:
                            Console.Write("Khong hop le");
                            return;
                    }
                }
            }
            Console.WriteLine("Khong tim duoc ID");
            return;
        }

        //3. Xoa sinh vien boi ID
        public void DeleteStudent(string iD) 
        {
            foreach (Student s in StudentList)
            {
                if (s.ID.Equals(iD))
                {
                    StudentList.Remove(s);
                    Console.WriteLine("Xoa thanh cong");
                    return;
                }
            }
            Console.WriteLine("Khong tim duoc ID");
            return;
        }

        //4. Tim kiem sinh vien theo ten
        public List<Student> SearchStudent (string name)
        {
            List<Student> results = new List<Student>();
            foreach (Student s in StudentList)
            {
                if (s.Name.Contains(name))
                {
                    results.Add(s);
                }
            }
            return results;
        }

        //5. Sap xep sinh vien theo diem trung binh
        public void SortStudentsByScore()
        {
            StudentList.Sort((x,y) => x.AverageScore.CompareTo(y.AverageScore));
        }

        //6. Sap xep sinh vien theo ten
        public void SortStudentsByName()
        {
            StudentList.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        //7. Sap xep sinh vien theo ID
        public void SortStudentsByID()
        {
            StudentList.Sort((x, y) => x.ID.CompareTo(y.ID));
        }

        //8. Hien thi danh sach sinh vien
        public void DisplayStudents(List<Student> list)
        {
            Console.WriteLine("|{0,10}|{1,20}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|{7,10}|{8,10}|", "ID", "Ten", "Gioi tinh", "Tuoi", "Diem toan", "Diem ly", "Diem hoa", "Trung binh", "Hoc luc");
            foreach (Student s in list)
            {
                Console.WriteLine("|{0,10}|{1,20}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|{7,10}|{8,10}|", s.ID, s.Name, s.Gender, s.Age, string.Format("{0:0.00}", s.MathScore), string.Format("{0:0.00}", s.PhysicsScore), string.Format("{0:0.00}", s.ChemistryScore), string.Format("{0:0.00}", s.AverageScore), s.RankedAcademic);
            }
        }




        /* ----------------------- MENU --------------------------- */
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
            Console.WriteLine("1) Them sinh vien");
            Console.WriteLine("2) Cap nhat thong tin sinh vien boi ID");
            Console.WriteLine("3) Xoa sinh vien boi ID");
            Console.WriteLine("4) Tim kiem sinh vien theo ten");
            Console.WriteLine("5) Sap xep sinh vien theo diem trung binh");
            Console.WriteLine("6) Sap xep sinh vien theo ten");
            Console.WriteLine("7) Sap xep sinh vien theo ID");
            Console.WriteLine("8) Hien thi danh sach sinh vien");
            Console.WriteLine("9) Thoat");
            Console.Write("\r\nChon viec: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Nhap cac thong tin:");
                    Console.Write("ID: ");
                    string iD = Console.ReadLine();
                    Console.Write("Ten: ");
                    string name = Console.ReadLine();
                    Console.Write("Gioi tinh: ");
                    string gender = Console.ReadLine();
                    Console.Write("Tuoi: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Diem toan: ");
                    double mathScore = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Diem ly: ");
                    double physicsScore = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Diem hoa: ");
                    double chemisScore = Convert.ToDouble(Console.ReadLine());

                    Student s = new Student(iD, name, gender, age, mathScore, physicsScore, chemisScore);
                    AddStudent(s);
                    return true;
                case "2":
                    Console.Write("Nhap ID muon cap nhat: ");
                    UpdateStudentByID(Console.ReadLine());
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.Write("Nhap ID sinh vien can xoa :");
                    DeleteStudent(Console.ReadLine());
                    Console.ReadKey();
                    return true;
                case "4":
                    Console.Write("Nhap ten can tim kiem: ");
                    List<Student> result = SearchStudent(Console.ReadLine());
                    if (result == null) 
                        Console.WriteLine("Khong tim duoc ket qua nao");
                    else
                        Console.WriteLine($"Co {result.Count} ket qua: ");
                        DisplayStudents(result);
                    Console.ReadKey();
                    return true;
                case "5":
                    SortStudentsByScore();
                    DisplayStudents(StudentList);
                    Console.ReadKey();
                    return true;
                case "6":
                    SortStudentsByName();
                    DisplayStudents(StudentList);
                    Console.ReadKey();
                    return true;
                case "7":
                    SortStudentsByID();
                    DisplayStudents(StudentList);
                    Console.ReadKey();
                    return true;
                case "8":
                    DisplayStudents(StudentList);
                    Console.ReadKey();
                    return true;
                case "9":
                    return false;
                default:
                    return true;
            }
        }

    }
}
