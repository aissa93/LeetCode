public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int EvenNum_Digits = 0;
        foreach(int e in nums)
        {
            if(e.ToString().Length % 2 == 0)
                EvenNum_Digits++;
        }
        return EvenNum_Digits;
    }
}