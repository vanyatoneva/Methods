using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] usersNums = new int[3];
            for(int i = 0; i < 3; i++)
            {
                usersNums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(FindSmallestInt(usersNums));
        }

        static int FindSmallestInt(int[] ints)
        {
            int smallest = ints[0];
            for(int i = 1; i < ints.Length; i++)
            {
                if(ints[i] < smallest)
                {
                    smallest = ints[i];
                }
            }
            return smallest;
        }
    }
}
