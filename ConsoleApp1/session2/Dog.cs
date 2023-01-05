using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session2
{
    internal class Dog : Animal, IAnimal
    {
        private double weight;
        private string color;
        public double Weight
        {
            get { return weight;}
            set { weight = value; }
        }
        public string Color
        {
            get => color; //Lambda expression
            set => color = value; 
        }

        //Constructor
        public Dog() { }
        public Dog(string species, double weight) :base(species)
        {
            this.weight = weight;
        }

       public void getInfo()
        {
            Console.WriteLine(GetSpecies());
        }

        public sealed override string GetSpecies()
        {
            return base.GetSpecies();
        }
    }
}
