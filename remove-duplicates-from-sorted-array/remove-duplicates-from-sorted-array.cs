public class Solution
{
    public int RemoveDuplicates(int[] nums) 
    {

        int actualIndex =  1;
        //0,0,1,1,1,2,2,3,3,4

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i-1])
            {
               nums[actualIndex++] = nums[i];
            }
            
        }
        return actualIndex;
    }
    
}