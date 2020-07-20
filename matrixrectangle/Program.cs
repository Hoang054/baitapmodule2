using System;

namespace matrixrectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int value;
            Console.WriteLine("Enter the size n:");
            string x = Console.ReadLine();
            bool tam = int.TryParse(x, out value);
            while (!tam || value < 1)
            {
                Console.WriteLine("Enter the size again:");
                x = Console.ReadLine();
                tam = int.TryParse(x, out value);
            }
            int n = Int32.Parse(x);

            Console.WriteLine("Enter the size m:");
            string x1 = Console.ReadLine();
            bool tam1 = int.TryParse(x1, out value);
            while (!tam1 || value < 1)
            {
                Console.WriteLine("Enter the size again:");
                x1 = Console.ReadLine();
                tam1 = int.TryParse(x1, out value);
            }
            int m = Int32.Parse(x1);
            int[,] arr = new int[n, m];
            Random rdd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rdd.Next(20, 60);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Enter the number :");
            string x2 = Console.ReadLine();
            bool tam2 = int.TryParse(x2, out value);
            while (!tam2 || value < 20 || value > 60)
            {
                Console.WriteLine("Enter the size again:");
                x2 = Console.ReadLine();
                tam2 = int.TryParse(x, out value);
            }
            int number = Int32.Parse(x2);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] == number)
                    {
                        Console.Write(number + "\t");
                    }
                    else
                        Console.Write("  " + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] % 5 == 0)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    else
                        Console.Write("  " + "\t");
                }
                Console.WriteLine();
            }
            int[,] A = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = arr[j, i];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
