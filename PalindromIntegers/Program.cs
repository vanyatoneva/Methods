using System;
using System.Linq;

namespace PalindromIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comm = Console.ReadLine();
            while(comm != "END")
            {
                PrintIfPalindrome(comm);
                comm = Console.ReadLine();
            }
        }

        static void PrintIfPalindrome(string userNums)
        {
            if (IsPalindrome(userNums))
            {
                Console.WriteLine("true");
                return;
            }
            Console.WriteLine("false");
        }

        static bool IsPalindrome(string userNums)
        {
            char[] num = userNums.ToArray();
            for(int i = 0; i < num.Length  / 2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
