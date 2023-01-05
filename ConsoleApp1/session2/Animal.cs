using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session2
{
    internal class Animal : AbstractAnimal
    {
        private string species;

        //Constructor
        public Animal() { }
        public Animal(string species)
        {
            this.species = species;
        }

        //Getters and setters
        public virtual string GetSpecies () { return species; }
        public void SetSpecies(string species) { this.species = species; }

        //Overide abstract methods
        public override void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public override void Run()
        {
            Console.WriteLine("Running...");
        }
    }
}
