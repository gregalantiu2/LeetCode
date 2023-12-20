
int[] nums = new int[6] {0,2,1,5,3,4};

Console.WriteLine(Solution.CheckAnswer(Solution.BuildArray(nums)).ToString());

public static class Solution {
    public static int[] BuildArray(int[] nums) {
        int[] answer = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            answer[i] = nums[nums[i]];
        }

        return answer;
    }

    public static bool CheckAnswer(int[] solution)
    {
        return solution.SequenceEqual(new int[] {0,1,2,4,5,3});
    }
}

/* 
    Better space complexity: https://leetcode.com/problems/build-array-from-permutation/solutions/2869937/o-1-solution/ 
    Using LINQ, and better time complexity: https://leetcode.com/problems/build-array-from-permutation/solutions/3107215/one-line-c-solution/
*/