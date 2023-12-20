using System.Linq;

int[] nums = new int[3] {1,2,1};

Console.WriteLine(Solution.CheckAnswer(Solution.GetConcatenation(nums)).ToString());
Console.WriteLine(Solution.CheckAnswer(Solution.GetConcatenation2(nums)).ToString());

public static class Solution {
    public static int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n * 2];

        for(int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }

        return ans;
    }

    public static int[] GetConcatenation2(int[] nums) {
        return nums.Concat(nums).ToArray();
    }

    public static bool CheckAnswer(int[] solution)
    {
        return solution.SequenceEqual(new int[] {1,2,1,1,2,1});
    }
}
