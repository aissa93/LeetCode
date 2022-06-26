public class Solution
{
    public int RemoveDuplicates(int[] nums) 
    {

        int actualIndex =  1;
        
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