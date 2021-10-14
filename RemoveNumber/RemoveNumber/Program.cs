using System;

namespace RemoveNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 3,2,2,3 };

            Solution.RemoveElement(array,3);
        }
    }
    public static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int[] newArray = new int[nums.Length];
            int counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    newArray[i] = nums[i];
                    counter++;
                }
            }
            nums = newArray;
            return counter;
        }
    }
}
