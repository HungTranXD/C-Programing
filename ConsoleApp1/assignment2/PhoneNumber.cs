using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment2
{
    internal class PhoneNumber
    {
        private string name;
        private List<string> numbers;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }   
        }
        public List<string> Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        //Constructors
        public PhoneNumber() { }
        public PhoneNumber(string name, List<string> numbers)
        {
            this.Name = name;
            this.Numbers = numbers;
        }
    }
}
