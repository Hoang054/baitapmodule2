using System;

namespace mang2chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter the size :");
            string x = Console.ReadLine();
            bool tam = int.TryParse(x ,out value);
            while(!tam || value < 1)
            {
                Console.WriteLine("Enter the size again:");
                x = Console.ReadLine();
                tam = int.TryParse(x, out value);
            }
            int n = Int32.Parse(x);
            int[,] arr = new int [n,n];

            Random rdd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   
                    arr[i, j] = rdd.Next(10,90);
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j= 0;j< n; j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"sum of even number is : {sum}");
            int sumdiagonal1 = 0;
            int sumdiagonal2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumdiagonal1 += arr[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                sumdiagonal2 += arr[i, n - i -1];
            }
            Console.WriteLine($"sum of 2 diagonal is : {sumdiagonal1}, {sumdiagonal2}");
            int sumborder = 0;
            for(int i =0; i < n; i++)
            {
                sumborder += arr[0, i] + arr[i, 0] + arr[n - 1, i] +arr[i, n - 1] ;
            }
            Console.WriteLine($"sum of border is : {sumborder}");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    if(j>=i)
                    break;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    if (j == n - i-1)
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
