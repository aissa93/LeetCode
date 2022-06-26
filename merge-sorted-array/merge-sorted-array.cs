public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    { 
        int i;
        if(n>0)
        {
            for(i = nums1.Length -1; i >= 0 && n>0 && m>0;i--)
            {
                if(nums2[n-1] > nums1[m-1])
                {
                    nums1[i] = nums2[n-1];
                    n--;
                }
                else
                {
                    nums1[i] = nums1[m-1];
                    m--;
                
                }
            }
            while(i >= 0 && n> 0)
            {
                nums1[i] = nums2[n-1];
                n--;
                i--;
            }
        }
    }
}