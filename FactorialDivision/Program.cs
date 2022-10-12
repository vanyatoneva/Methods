using System;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetDivisionFactrorials(a, b):f2}");
        }

        static long GetFactorial(int n)
        {
            if(n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return n * GetFactorial(n - 1);
            }
        }

        static double GetDivisionFactrorials(int a, int b)
        {
            long aFact = GetFactorial(a);
            long bFact = GetFactorial(b);
            if(bFact != 0)
            {
                return (double)aFact / bFact;
            }
            return -1;
        }
    }
}
