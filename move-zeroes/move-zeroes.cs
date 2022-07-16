public class Solution {
    public void MoveZeroes(int[] nums)
        {
            if (nums != null && nums.Length > 1)
            {
                int actualIndex = 0, zerocount = 0;
                //[0,1,0,3,12]
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                       
                       zerocount++;
                    }
                    else
                    {
                        nums[actualIndex] = nums[i];
                        actualIndex++;
                    }

                }
                for(int i = nums.Length -1; i > nums.Length - zerocount -1; i--)
                    nums[i] = 0;
            }

        }
}