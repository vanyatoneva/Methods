using System;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        static void PrintArray(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{n} ");
            }
        }

        static void PrintMatrix(int n)
        {
            for(int i = 0; i < n; i++)
            {
                PrintArray(n);
                Console.WriteLine();
            }
        }
    }
}
