using System;

namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintCharacters(a, b);

        }

        static void PrintCharacters(char a, char b)
        {
            if(b < a)
            {
                char temp  = a;
                a = b;
                b = temp;
            }
            for(int i = (int)a + 1; i < (int)b; i++)
            {
                Console.Write($"{((char)i)} ");
            }
        }
    }
}
