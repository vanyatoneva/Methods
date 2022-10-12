using System;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            for(int i = 0; i < int.Parse(n); i++)
            {
                if (IsTopInteger(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopInteger(string num)
        {
            if(IsDivisilbeByEight(num) && HasOddDigit(num)){
                return true;
            }
            return false;
        }

        static bool IsDivisilbeByEight(string num)
        {
            double n = Math.Pow(10.00, (double)num.Length);
            int intNum = int.Parse(num);
            long sum = 0; 
            while(n >= 1)
            {
                sum += intNum / (int)n;
                intNum %= (int)n;
                n /= 10;
            }

            if(sum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool HasOddDigit(string num)
        {
            double n = Math.Pow(10.00, (double)num.Length);
            int intNum = int.Parse(num);
            while(n >= 1)
            {
                if((intNum / (int)n) % 2 == 1)
                {
                    return true;
                }
                intNum %= (int)n;
                n /= 10;
            }
            return false;
        }
    }
}
