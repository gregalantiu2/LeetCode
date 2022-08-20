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

            numbers.Split(",").ToList();

            int[] realNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                realNumbers[i] = Int32.Parse(realNumbers[i].ToString());
            }

            var result = twoSum(realNumbers, target);

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

        public static int[] twoSum(int[] nums, int target)
        {
            return new int[] { 1 , 2};
        }
    }
}