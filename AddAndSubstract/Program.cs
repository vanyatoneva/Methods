using System;

namespace AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[3];
            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Substract(FindSum(ints[0], ints[1]), ints[2]));
        }

        static int FindSum(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
