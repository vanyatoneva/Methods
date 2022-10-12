using System;

namespace PasswodValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            checkPassword(pass);
        }

        static void checkPassword(string pass)
        {
            bool isValid = true;
            if (!IsValidLength(pass))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!AreValidChar(pass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid=false;
            }
            if (!HasTwoDigits(pass))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid=false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsValidLength(string pass)
        {
            bool isValid = true;
            if(pass.Length < 6 || pass.Length > 10)
            {
                isValid = false;
            }
            return isValid;
        }

        static bool AreValidChar(string pass)
        {
            //bool valid = true;
            char[] passWord = pass.ToCharArray();
            for(int i = 0; i < passWord.Length; i++)
            {
                if ((int)passWord[i] < 48 || ((int)passWord[i] > 57 && (int)passWord[i] < 65) ||
                    ((int)passWord[i] > 90 && (int)passWord[i] < 97) || (int)passWord[i] > 122)
                {
                    return false;
                }
            }
            return true;
        }

        static bool HasTwoDigits(string pass)
        {
            char[] password = pass.ToCharArray();
            int digits = 0;
            for(int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] >= 48 && (int)password[i] <= 58)
                {
                    digits++;
                    if(digits == 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
