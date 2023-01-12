using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment4
{
    internal class News : INews
    {
        //Fields
        private int[] RateList = new int[3];
        private int[] RateList2 = new int[3];

        //Properties
        public int ID { get; set; } 
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AvarageRate { get; private set; } //Read-only property

        //Construcstor
        public News() { }
        public News(int iD, string title, string publishDate, string author, string content)
        {
            ID = iD;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            
        }

        //Implemente method
        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("PublishDate: " + PublishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("AvarageRate: " + AvarageRate);
        }

        //Inderxer
        public int this[int index]
        {
            get => RateList[index];
            set => RateList[index] = value;
        }

        //Instance methods
        public void Calculate()
        {
            AvarageRate = (float) RateList.Average();
        }
    }
}
