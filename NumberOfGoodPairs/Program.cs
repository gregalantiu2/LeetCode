﻿int[] nums = new int[6] {1,2,3,1,1,3};

Console.WriteLine(Solution.CheckAnswer(Solution.NumberOfGoodPairs(nums)).ToString());

public static class Solution {
    public static int NumberOfGoodPairs(int[] nums) {
        int answer = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    answer++;
                }
            }
        }

        return answer;
    }

    public static bool CheckAnswer(int solution)
    {
        return solution == 4;
    }
}
