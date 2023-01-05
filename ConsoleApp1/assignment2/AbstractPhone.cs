using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment2
{
    internal abstract class AbstractPhone
    {
        public abstract void InsertPhone (string name, string phone);
        public abstract void RemovePhone (string name);
        public abstract void UpdatePhone (string name, string oldPhone, string newPhone);
        public abstract PhoneNumber SearchPhone (string name);
        public abstract void Sort();
        
    }
}
