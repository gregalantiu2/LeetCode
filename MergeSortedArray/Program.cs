int[] nums1 = new int[6] {1,2,3,0,0,0};
int m = 3;
int[] nums2 = new int[3] {2,5,6};
int n = 3;


Console.WriteLine(Solution.CheckAnswer(Solution.Solution_Implementation(nums1,m,nums2,n)).ToString());

public static class Solution {
    public static int[] Solution_Implementation(int[] nums1, int m, int[] nums2, int n) {

        int p1 = m - 1;  
        int p2 = n - 1;  
        int p = m + n - 1; 

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] < nums2[p2])
            {
                nums1[p--] = nums2[p2--];
            }
            else
            {
                nums1[p--] = nums1[p1--];
            }
        }

        System.Array.Copy(nums2, 0, nums1, 0, p2 + 1);

        return nums1;
    }

    public static bool CheckAnswer(int[] solution)
    {
        return solution.SequenceEqual(new int[] {1,2,2,3,5,6});
    }
}
