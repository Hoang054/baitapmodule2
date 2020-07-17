using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    public class Post : IPost
    {
        private int id;
        private string title;
        private string content;
        private string author;
        private double averageRate;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Author { get => author; set => author = value; }
        public double AverageRate { get => averageRate; }
        public int Count;
        public List<int> Rates = new List<int>();
        public void CalculatorRate()
        {
            double sum = 0;
            foreach (var item in Rates) 
            {
                sum += item;
            }
            this.averageRate = sum / Rates.Count ;
        }

        public void Display()
        {
            Console.WriteLine($"{Id} \t{Title} \t{Content} \t\t {Author} \t\t {Count} \t\t {AverageRate}");
        }

        public Post() { }

    }
}
