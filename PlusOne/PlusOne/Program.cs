using System;
using System.Linq;

namespace PlusOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution.PlusOne(new int[] {9,8,7,6,5,4,3,2,1,0});
        }
        
    }
    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            int lastInt = digits[digits.Length - 1];
            int secondTolast = 0;
            if (digits.Length > 1)
            {
                secondTolast = digits[digits.Length - ];
            }

            lastInt++;

            if(lastInt >= 10)
            {
                if(digits.Length > 1)
                {
                    lastInt = 0;
                    secondTolast++;
                }
                else
                {
                    return lastInt.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                }
            }
            digits[digits.Length - 1] = +lastInt;
            return digits;
        }
    }
}
