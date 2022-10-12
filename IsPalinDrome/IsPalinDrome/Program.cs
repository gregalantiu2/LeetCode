using System;
using System.Linq;

namespace IsPalinDrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a a word: ");
            var input = Console.ReadLine();
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

        public static bool IsPalindrome(string x)
        {
            var container = x.ToLower().Replace(" ", string.Empty).ToCharArray();

            container = Array.FindAll(container, char.IsLetterOrDigit);
            
            var reverseContainer = new char[container.Length];

            Array.Copy(container, reverseContainer, container.Length);

            Array.Reverse(reverseContainer);

            return Enumerable.SequenceEqual(container, reverseContainer);
        }
    }
}