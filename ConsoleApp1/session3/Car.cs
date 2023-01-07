using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session3
{
    internal class Car
    {
        //Fields
        public List<string> parts = new List<string>();

        //Constructors
        public Car() 
        {
            parts.Add("Engine");
            parts.Add("Breakes");
            parts.Add("Headlights");
        }

        //Properties
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        //Indexer (Coi object như 1 mảng)
        public string this[int index]
        {
            get => parts[index];
            set => parts[index] = value;
        }
    }
}
