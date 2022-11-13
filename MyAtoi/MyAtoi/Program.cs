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
            bool containsNumber = false;

            for (int i = 0; i < characters.Length; i++)
            {
                if (i == 0 && (characters[i] == '-' || characters[i] == '+'))
                {
                    result += characters[i].ToString();
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
                        containsNumber = true;
                        result += number.ToString();
                    }
                }
            }

            int answer;
            bool canParse = Int32.TryParse(result, out answer);
            if (canParse == false && containsNumber == true && characters[0] == '-')
            {
                return Int32.MinValue;
            }
            else if (canParse == false && containsNumber == true)
            {
                return Int32.MaxValue;
            }
            else if(canParse == false)
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