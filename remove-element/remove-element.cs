public class Solution 
{
     public int RemoveElement(int[] nums, int val)
    {
        int valueCount = 0;
        int lastIndex =  nums.Length - 1;
        for(int i = 0; i <= lastIndex; i++)
        {
            if(nums[i] != val)
                nums[valueCount++] = nums[i] ;
               
        }

        return valueCount;
    }
}