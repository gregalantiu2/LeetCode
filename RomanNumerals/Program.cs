﻿using System;
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

            List<int> numbers = new List<int>();
            bool skip = false;
            int result = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if((i + 1 < stringArray.Length) && (stringArray[i + 1].ToString() != stringArray[i].ToString()
                    && (dict[stringArray[i].ToString()] < dict[stringArray[i + 1].ToString()])))
                {
                    numbers.Add(dict[stringArray[i + 1].ToString()] - dict[stringArray[i].ToString()]);
                    result += dict[stringArray[i + 1].ToString()] - dict[stringArray[i].ToString()];
                    skip = true;
                }
                else
                {
                    if(skip != true)
                    {
                        numbers.Add(dict[stringArray[i].ToString()]);
                    }
                    else
                    {
                        skip = false;
                    }
                }
            }


            result += (1 * numbers.Where(x => x == 1).Count());
            result += (5 * numbers.Where(x => x == 5).Count());
            result += (10 * numbers.Where(x => x == 10).Count());
            result += (50 * numbers.Where(x => x == 50).Count());
            result += (100 * numbers.Where(x => x == 100).Count());
            result += (500 * numbers.Where(x => x == 500).Count());
            result += (1000 * numbers.Where(x => x == 1000).Count());

            return result;
        }
    }
}
