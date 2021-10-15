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
            int counter = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    counter++;
                    index++;
                }
                else
                {
                    nums[i] = 0;
                }
            }
            return counter;
        }
    }
}
