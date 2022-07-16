public class Solution {
    public int HeightChecker(int[] heights) 
    {
        int unmatch = 0;
        int[] orderedHights = (int[])heights.Clone();
        Array.Sort(orderedHights);
        for(int i = 0; i < heights.Length; i++)
            if(orderedHights[i] != heights[i])
                unmatch++;
        return unmatch;
    }
}