using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1234;
            IsPalindrome(n);

        }

        static bool IsPalindrome(int n)
        {

            string non = n.ToString();
            int num = n;


            char[] inserter = new char[non.Length];
            char[] reversed = new char[non.Length];
            inserter = non.ToCharArray();

            int counter = non.Length - 1;
            for (int i = 0; i < non.Length; i++)
            {

                reversed[counter] = inserter[i];
                counter--;
            }
            
            for (int i = 0; i < non.Length; i++)
            {
                if(reversed[i] != inserter[i])
                {
                    Console.WriteLine("is false");
                    return false;
                }
            }

            return true;
            
        }
    }


}
