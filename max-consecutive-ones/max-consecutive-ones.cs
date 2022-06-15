public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {

        int MaxConsecutiveOnes = 0, ConsecutiveOnes = 0;
        for(int i = 0; i < nums.Length; i++)
        {

            if(nums[i] == 1)
            {
                ConsecutiveOnes++;
            }
            else
            {
                if(MaxConsecutiveOnes < ConsecutiveOnes)
                {
                    MaxConsecutiveOnes = ConsecutiveOnes;
                }
                ConsecutiveOnes = 0;
            }

        }
        return MaxConsecutiveOnes < ConsecutiveOnes ? ConsecutiveOnes : MaxConsecutiveOnes;
    }
}
