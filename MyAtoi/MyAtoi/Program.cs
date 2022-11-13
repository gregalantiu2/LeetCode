using System;

namespace MyAtoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number or string");
            var input = Console.ReadLine();
            Console.WriteLine("Number detected: " + Program.MyAtoi(input).ToString());
        }
        public static int MyAtoi(string s)
        {
            var input = s.Trim();

            if (input.Length == 0)
            {
                return 0;
            }

            var characters = input.ToCharArray();

            string result = "";

            for (int i = 0; i < characters.Length; i++)
            {
                if (i == 0 && characters[i] == '-')
                {
                    result += "-";
                }
                else
                {
                    int number;
                    if (Int32.TryParse(characters[i].ToString(), out number) == false)
                    {
                        break;
                    }
                    else
                    {
                        result += number.ToString();
                    }
                }
            }

            int answer;
            if (Int32.TryParse(result, out answer) == false)
            {
                return 0;
            }
            else
            {
                return answer;
            }
        }
    }
}