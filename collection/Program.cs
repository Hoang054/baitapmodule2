using System;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        public static Forum forum = new Forum();
        
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
                        Console.Write("Enter id: ");
                        int id = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter content: ");
                        string content = Console.ReadLine();
                        UpdatePost(id, content);
                        break;
                    case 3:
                        Console.Write("Enter id: ");
                        int Id = Int32.Parse(Console.ReadLine());
                        RemovePost(Id);
                        break;
                    case 4:
                        ShowPost();
                        break;
                    case 5:
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Title: ");
                        string Title = Console.ReadLine();
                        SearchByauthor(author);
                        SearchByTitle(Title);
                        break;
                    case 6:
                        Console.Write("Enter id: ");
                        int Id1 = Int32.Parse(Console.ReadLine());
                        forum.Rating(Id1);
                        break;
                }
            }
        }
        public static void CreatPost()
        {
            //ID++;
            //Console.WriteLine("Enter title");
            //newpost.Title = Console.ReadLine();
            //Console.WriteLine("Enter content");
            //newpost.Content = Console.ReadLine();
            //Console.WriteLine("Enter author");
            //newpost.Author = Console.ReadLine();
            //Console.WriteLine("Enter id");
            //Console.Write($"Enter rate for Id({forum.Posts[newpost.Count - 1].Id}):");
            //newpost.Rates[newpost.Count - 1] = Int32.Parse(Console.ReadLine());
            //newpost.Id = ID;
            forum.Add();
            
        }
        public static void UpdatePost(int Id, string Content)
        {
            forum.Update(Id, Content);
        }
        public static void RemovePost(int Id)
        {
            forum.Remove(Id);
        }
        public static void ShowPost()
        {
            forum.Show();
        }
        public static void SearchByauthor(string Author)
        {
            forum.SearchByauthor(Author);
        }
        public static void SearchByTitle(string Title)
        {
            forum.SearchByTitle(Title);
        }
        //public static void Rating(int Id)
        //{
        //    bool tam = false;
        //    if (Posts.ContainsKey(idKey)) {
        //        int value;
        //        Console.WriteLine("Enter the Rate for post from 1 to 5:");
        //        string x = Console.ReadLine();
        //        bool tam1 = (int.TryParse(x, out value));
        //        while (!tam1 || value > 6 || value < 0)
        //        {
        //            Console.WriteLine("Enter just number Rate from 1 to 5");
        //            x = Console.ReadLine();
        //            tam1 = (int.TryParse(x, out value));
        //        }
        //        newpost.Rates[i] = Int32.Parse(x);
        //        tam = true;
        //    }
        //    if(tam == false)
        //    {
        //        Console.WriteLine("Invalid Post");
        //    }
        //}
    }
}
