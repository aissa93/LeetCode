public class Solution 
{
    public bool ValidMountainArray(int[] arr)
    {
        bool result = true;
        int arrLength = arr.Length;
        if(arrLength < 3)
            return false;
        
        int index_peak = this.getPeak(arr);
        if(index_peak == arrLength - 1 || index_peak == 0)
            return false;
        for(int i = index_peak; i>0;i--)
        {
            if(arr[i] > arr[i-1])
                result = result && true;
            else
                return false;
        }
        for(int i = index_peak; i< arrLength-1;i++)
        {
            if(arr[i] > arr[i+1])
                result = result && true;
            else
                return false;
        }
        return result;
    }

    public int getPeak(int[] arr)
    {
        int peak = 0;
        int maxValue = arr.Max();
        peak = arr.ToList().IndexOf(maxValue);
        return peak;
    }
}