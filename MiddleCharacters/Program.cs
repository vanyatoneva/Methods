using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text = Console.ReadLine();
            printMiddleCharacters(Text);
        }

        static bool isEven(string text)
        {
            if(text.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static void printMiddleCharacters(string text)
        {
            if(text.Length == 0)
            {
                return;
            }
            int middle = text.Length / 2;
            char[] textChars = text.ToCharArray();
            if (isEven(text))
            {
                Console.Write($"{textChars[middle - 1]}{textChars[middle]}");
            }
            else
            {
                Console.Write(textChars[middle]);
            }
        }
    }
}
