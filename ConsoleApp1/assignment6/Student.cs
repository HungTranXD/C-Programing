using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment6
{
    enum RankedAcademic { 
        Excellent,
        Good,
        Average,
        Weak
    }
    internal class Student
    {
        //Properties
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double MathScore { get; set; }
        public double PhysicsScore { get; set; }
        public double ChemistryScore { get; set; }
        public double AverageScore { get; private set; }
        public RankedAcademic RankedAcademic { get; private set; }

        //Constructors
        public Student()
        {
        }
        public Student(string iD, string name, string gender, int age, double mathScore, double physicsScore, double chemistryScore)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Age = age;
            MathScore = mathScore;
            PhysicsScore = physicsScore;
            ChemistryScore = chemistryScore;
            CalculateAverageScore();
            DeterminedRankedAcademic();
        }

        //Methods
        public void CalculateAverageScore()
        {
            AverageScore = (MathScore + PhysicsScore + ChemistryScore) / 3;
        }

        public void DeterminedRankedAcademic()
        {
            if (AverageScore >= 8) RankedAcademic = RankedAcademic.Excellent;
            else if (AverageScore >= 6.5) RankedAcademic = RankedAcademic.Good;
            else if (AverageScore >= 5) RankedAcademic = RankedAcademic.Average;
            else RankedAcademic = RankedAcademic.Weak;
        }

    }
}
