using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_RomanNumerals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Solution.RomanToInt("MCMXCIV");
        }
    }
    public static class Solution
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000}
             };

            char[] stringArray = s.ToCharArray();
            bool skip = false;
            int result = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if((i + 1 < stringArray.Length) && (stringArray[i + 1].ToString() != stringArray[i].ToString()
                    && (dict[stringArray[i].ToString()] < dict[stringArray[i + 1].ToString()])))
                {
                    result += dict[stringArray[i + 1].ToString()] - dict[stringArray[i].ToString()];
                    skip = true;
                }
                else
                {
                    if(skip != true)
                    {
                        result += dict[stringArray[i].ToString()];
                    }
                    else
                    {
                        skip = false;
                    }
                }
            }

            return result;
        }
    }
}
