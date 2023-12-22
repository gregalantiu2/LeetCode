using System.Collections.Generic;

int[] prices1 = new int[6] {7,1,5,3,6,4};
int[] prices2 = new int[5] {7,6,4,3,1};

Console.WriteLine(Solution.CheckAnswer1(Solution.MaxProfit(prices1)).ToString());
Console.WriteLine(Solution.CheckAnswer2(Solution.MaxProfit(prices2)).ToString());

public static class Solution {
    public static int MaxProfit(int[] nums) {
        Dictionary<int,int> tracker = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!tracker.Any())
            {
                tracker[0] = num;
                tracker[1] = num;
                continue;
            }

            
        }

        return tracker[1] - treacker[0];
    }

    public static bool CheckAnswer1(int solution)
    {
        return solution == 5;
    }
    public static bool CheckAnswer2(int solution)
    {
        return solution == 0;
    }
}
