using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a string");
            var input = Console.ReadLine();
            Console.WriteLine(Program.ReverseString(input.ToCharArray()));
        }

        public static char[] ReverseString(char[] s)
        {
            Array.Reverse(s);
            string result = "";
            foreach (var character in s)
            {
                result += character;
            }
            return s;
        }
    }
}