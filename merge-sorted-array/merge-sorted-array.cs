public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    { 
        int index_1 = m-1;
        int index_2 = n-1;
        int index_big = m + n -1;
        
        while(index_1 >= 0 && index_2 >= 0)
        {
            if(nums1[index_1] > nums2[index_2])
            {
                nums1[index_big] =  nums1[index_1];
                index_1--;
            }
            else
            {
                nums1[index_big] =  nums2[index_2];
                index_2--;
            }
            index_big--;
        }
            while(index_2 >= 0)
            {
                nums1[index_big] = nums2[index_2];
                index_1--;
                index_2--;
                index_big--;
            }
        }
    
}