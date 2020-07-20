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
        public void Add(int Id,Post _post)
        {
            
            Posts.Add(Id, _post);
           
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
                    
                }
            }
            if(keyByTitle != -1)
            Posts[keyByTitle].Display();
            else
            {
                Console.WriteLine("not found");
            }
        }
        
    }
}
