using System;

namespace PalindromeCharArray
{
    class CharPalindrome
    {
        internal bool CheckPalindrome(char[] name)
        {
            int i, j, n;
            bool palindrome = true;
            n = name.Length;
            for (i = 0, j = n - 1; i < n / 2; i++, j--)
            {
                if (name[i] != name[j])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char[] name = new char[10];
            Console.Write("Enter any string: ");
            name = Console.ReadLine().ToCharArray();
            Console.WriteLine("Palindrome: " + new CharPalindrome().CheckPalindrome(name));
        }
    }
}
