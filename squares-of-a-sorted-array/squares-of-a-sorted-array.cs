public class Solution {
    public int[] SortedSquares(int[] nums)
    {
        int[] sortedSquares = new int[nums.Length];
        int i = 0, j = nums.Length - 1;
        int k = nums.Length - 1;
        while(i <= j)
        {
            if(nums[i] * nums[i] > nums[j] * nums[j])
            {
                sortedSquares[k] = nums[i] * nums[i];
                i++;
            }
            else
            {
                sortedSquares[k] = nums[j] * nums[j];
                j--;
            }
            k--;
        }
        return sortedSquares;
        
    }
}