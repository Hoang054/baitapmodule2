using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    class Forum
    {
        public SortedList<int, Post> Posts = new SortedList<int, Post>();
        public static int increID = 10000;
        public static int count = 0;
        public void Add()
        {
            increID++;
            count++;
            var _post = new Post();
            _post.Id = increID;
            Console.Write("Title: ");
            _post.Title = Console.ReadLine();
            Console.Write("Author: ");
            _post.Author = Console.ReadLine();
            Console.Write("Content: ");
            _post.Content = Console.ReadLine();
            int value;
            Console.WriteLine("Enter the Rate for post from 1 to 5:");
            string x = Console.ReadLine();
            bool tam1 = (int.TryParse(x, out value));
            while (!tam1 || value > 5 || value < 0)
            {
                Console.WriteLine("Enter just number Rate from 1 to 5");
                x = Console.ReadLine();
                tam1 = (int.TryParse(x, out value));
            }
            _post.Rates.Add(Int32.Parse(x));
            _post.CalculatorRate();
            _post.Count = count;
            Posts.Add(_post.Id, _post);
           
        }
        public void Update(int Id, string Content)
        {
            if (Posts.ContainsKey(Id))
                Posts[Id].Content = Content;
            else
                Console.WriteLine("Invalid Post");
        }
        public void Remove (int Id)
        {
            if (Posts.ContainsKey(Id))
                Posts.Remove(Id);
            else
                Console.WriteLine("Invalid Post");
        }   
        public void Show()
        {
            ICollection key = (ICollection)Posts.Keys;
            Console.WriteLine("Id \t title \t author \t content \t count \t averageRate");
            foreach ( int item in key)
            {
                Posts[item].Display();
            }
        }
        public void SearchByauthor(string author)
        {
            int keyByAuthor = -1;
            ICollection key = (ICollection)Posts.Keys;

            foreach (int idk in key)
            {
                if (Posts[idk].Author == author)
                {
                    keyByAuthor = idk;
                    break;
                }
            }
            if (keyByAuthor != -1)
                Posts[keyByAuthor].Display();
            else
            {
                Console.WriteLine("not found");
            }
        }
        public void SearchByTitle(string title)
        {
            int keyByTitle = -1;
            foreach (var key in Posts.Keys)
            {
                if (Posts[key].Title == title)
                {
                    keyByTitle = key;
                    break;
                }
            }
            if(keyByTitle != -1)
            Posts[keyByTitle].Display();
            else
            {
                Console.WriteLine("not found");
            }
        }
        public void Rating(int idKey)
        {
            bool tam = false;
            if (Posts.ContainsKey(idKey))
            {
                int value;
                Console.WriteLine("Enter the Rate for post from 1 to 5:");
                string x = Console.ReadLine();
                bool tam1 = (int.TryParse(x, out value));
                while (!tam1 || value > 5 || value < 0)
                {
                    Console.WriteLine("Enter just number Rate from 1 to 5");
                    x = Console.ReadLine();
                    tam1 = (int.TryParse(x, out value));
                }
                Posts[idKey].Rates.Add(Int32.Parse(x));
                Posts[idKey].CalculatorRate();
                tam = true;
            }
            if (tam == false)
            {
                Console.WriteLine("Invalid Post");
            }
        }
    }
}
