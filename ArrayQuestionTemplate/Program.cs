int[] nums = new int[6] {0,2,1,5,3,4};

Console.WriteLine(Solution.CheckAnswer(Solution.Solution_Implementation(nums)).ToString());

public static class Solution {
    public static int[] Solution_Implementation(int[] nums) {
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
