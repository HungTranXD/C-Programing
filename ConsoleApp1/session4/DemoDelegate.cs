using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session4
{
    public delegate void PrintString(string s);
    internal class DemoDelegate
    {
        public void ShowMessage(string s)
        {
            Console.WriteLine("Info: " + s);
        }

        public static void Alert(string s) 
        {
            Console.WriteLine("Alert: " + s);
        }
    }
}
