public class Solution {
    public int[] SortArrayByParity(int[] nums)
        {
            int forwardIndx = 0, backwardIndx = nums.Length - 1;
            while (forwardIndx < backwardIndx)
            {
                if (nums[forwardIndx] % 2 != 0 && nums[backwardIndx] % 2 == 0)
                {
                    int eventmp = nums[backwardIndx];
                    nums[backwardIndx] = nums[forwardIndx];
                    nums[forwardIndx] = eventmp;
                    forwardIndx++;
                    backwardIndx--;
                }
                else
                {
                    if (nums[forwardIndx] % 2 == 0)
                        forwardIndx++;
                    if (nums[backwardIndx] % 2 != 0)
                        backwardIndx--;
                }
            }

            return nums;
        }
}