using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter the size :");
            string x = Console.ReadLine();
            bool tam = int.TryParse(x, out value);
            while (!tam || value < 1)
            {
                Console.WriteLine("Enter the size again:");
                x = Console.ReadLine();
                tam = int.TryParse(x, out value);
            }
            int n = Int32.Parse(x);
            int[,] arr2 = new int[n, n];
            int[,] arr1 = new int[n, n];

            Random rdd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = rdd.Next(10, 40);
                    arr2[i, j] = rdd.Next(10, 40);
                }
            }
            Console.WriteLine("array 1 :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("array 2 :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum of array :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] + arr1[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("multiplication of array :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] * arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
