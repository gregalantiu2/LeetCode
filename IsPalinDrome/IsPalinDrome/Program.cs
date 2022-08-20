using System;
using System.Linq;

namespace IsPalinDrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number: ");
            var input = Int32.Parse(Console.ReadLine());
            var result = IsPalindrome(input);
            
            if (result == true)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }
        }

        public static bool IsPalindrome(int x)
        {
            var container = x.ToString().ToCharArray();
            
            var reverseContainer = x.ToString().ToCharArray(); 
            Array.Reverse(reverseContainer);

            return Enumerable.SequenceEqual(container, reverseContainer);
        }
    }
}