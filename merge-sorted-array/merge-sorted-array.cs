public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int[] actualNums1 = this.copyArray(nums1, m);
        
        int index1 = 0, index2 = 0;
        if(m == 1 && nums1[0] == 0)
            nums1[0] = nums2[0];
        else
        {
            for(int i = 0; i< nums1.Length && n >0; i++)
            {
                if(index1 == m )
                {
                    nums1[i] = nums2[index2];
                    index2++;
                }
                else if(index2 == n)
                {
                    nums1[i] = actualNums1[index1];
                    index1++;            
                }
                else if(actualNums1[index1] < nums2[index2])
                {
                
                    nums1[i] = actualNums1[index1];
                    index1++;
                }
                else
                {
                    nums1[i] = nums2[index2];
                    index2++;
                }
            
            }
        }
    }


    int[] copyArray(int[] nums1, int m)
    {
        int[] actualNums1 = new int[m];
        for (int i = 0; i < m; i++)
        {
            actualNums1[i] = nums1[i];
        }
        return actualNums1;
    }
}