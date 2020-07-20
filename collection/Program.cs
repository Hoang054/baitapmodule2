using System;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int increID = 10000;
        public static int count = 0;
        public static int ID = 0;
        static void Main(string[] args)
        {
            var tam = new Post();
            //newpost[0] = tam;
            int choice = 0;
            while (choice != 7)
            {
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Posts");
                Console.WriteLine("5. Search");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreatPost();
                        break;
                    case 2:
                        
                        UpdatePost();
                        break;
                    case 3:
                        
                        RemovePost();
                        break;
                    case 4:
                        ShowPost();
                        break;
                    case 5:
                        Console.WriteLine("choice 1 to search by author, 2 by title:");
                        int choice2 = Int32.Parse(Console.ReadLine());
                        while (choice > 2 || choice <1)
                        {
                            switch (choice2)
                            {
                                case 1:
                                    SearchByauthor();
                                    break;
                                case 2:
                                    SearchByTitle();
                                    break;
                            }
                        }
                        break;
                    case 6:
                        
                        Rating();
                        break;
                }
            }
        }
        public static void CreatPost()
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
            forum.Add(increID, _post);
            
        }
        public static void UpdatePost()
        {
            Console.Write("Enter id: ");
            int Id = Int32.Parse(Console.ReadLine());
            Console.Write("Enter content: ");
            string Content = Console.ReadLine();
            forum.Update(Id, Content);
        }
        public static void RemovePost()
        {
            Console.Write("Enter id: ");
            int Id = Int32.Parse(Console.ReadLine());
            forum.Remove(Id);
        }
        public static void ShowPost()
        {
            forum.Show();
        }
        public static void SearchByauthor()
        {
            Console.Write("Enter Author: ");
            string Author = Console.ReadLine();
            
            forum.SearchByauthor(Author);
        }
        public static void SearchByTitle()
        {
            Console.Write("Enter Title: ");
            string Title = Console.ReadLine();
            forum.SearchByTitle(Title);
        }
        public static void Rating()
        {
            Console.Write("Enter id: ");
            int idKey = Int32.Parse(Console.ReadLine());
            bool tam = false;
            if (forum.Posts.ContainsKey(idKey))
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
                forum.Posts[idKey].Rates.Add(Int32.Parse(x));
                forum.Posts[idKey].CalculatorRate();
                tam = true;
            }
            if (tam == false)
            {
                Console.WriteLine("Invalid Post");
            }
        }
    }
}
