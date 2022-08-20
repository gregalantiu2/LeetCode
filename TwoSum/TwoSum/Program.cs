using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in some numbers separated by commas");
            var numbers = Console.ReadLine();
            
            Console.WriteLine("Enter in a target sum");
            var target = Int32.Parse(Console.ReadLine());

            var numbersList = numbers.Split(",").ToList();

            int[] realNumbers = new int[numbersList.Count()];

            for (int i = 0; i < numbersList.Count; i++)
            {
                realNumbers[i] = Int32.Parse(numbersList[i].ToString());
            }

            var result = twoSum(realNumbers, target);

            if (result.Length < 1)
            {
                Console.WriteLine("No Matches");
            }
            else
            {
                string stringResult = "[";
            
                for (int i = 0; i < result.Length; i++)
                {
                    if (i != result.Length - 1)
                    {
                        stringResult += result[i].ToString() + ",";    
                    }
                    else
                    {
                        stringResult += result[i].ToString();
                    }
                }

                stringResult += "]";
            
                Console.WriteLine(stringResult);
            }
        }

        public static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int match = target - nums[i];

                int matchIndex = Array.IndexOf(nums, match);
                
                if ((matchIndex > -1) && (i != matchIndex))
                {
                    var answer = new int[] { i, matchIndex };
                    Array.Sort(answer);
                    return answer;
                }
            }
            
            return new int[] { };
        }
    }
}