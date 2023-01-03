using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // giong import

namespace ConsoleApp1.session1 //giong package trong Java nhung namespace khong lien quan den folder (tu dat ten cung duoc, sau nay cung namespace thi duoc tong hop trong dll)
{
    internal class Human
    {
        public string name;
        public int age;

        public void Eat() //ham trong C# thuong viet hoa chu dau
        {
            Console.WriteLine("Eating...");
        }

        public void Run()
        {
            Console.WriteLine(this.name + " running...");
        }

    }
}
