using System;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();
            Console.WriteLine(VowelsCount(userText));
        }

        
        static int VowelsCount(string text)
        {
            int count = 0;
            char[] chars = text.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if (isVowel(chars[i]))
                {
                    count++;
                }
            }
            return count;
        }

        static bool isVowel(char a)
        {
            bool isVowel = false;
            if ((int)a == 65 || (int)a == 69 || (int)a == 73|| (int)a == 79|| (int)a == 85||
                (int)a == 97|| (int)a == 101|| (int)a == 105 || (int)a == 111|| (int)a == 117)
            {
                isVowel = true;
            }
            ; return isVowel;
        }

    }
}
