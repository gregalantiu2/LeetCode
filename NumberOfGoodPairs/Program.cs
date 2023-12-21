using System.Collections.Generic;

int[] nums = new int[6] {1,2,3,1,1,3};

Console.WriteLine(Solution.CheckAnswer(Solution.NumberOfGoodPairs(nums)).ToString());
Console.WriteLine(Solution.CheckAnswer(Solution.NumberOfGoodPairs2(nums)).ToString());

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

    public static int NumberOfGoodPairs2(int[] nums) {
        Dictionary<int,int> tracker = new Dictionary<int,int>();
        int answer = 0;

        foreach(int num in nums)
        {
            if(tracker.ContainsKey(num))
            {
                answer += tracker[num];
                tracker[num]++;
            }
            else
            {
                tracker[num] = 1;
            }
        }

        return answer;
    }

    public static bool CheckAnswer(int solution)
    {
        return solution == 4;
    }
}
