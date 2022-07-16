public class Solution 
{
    public int[] ReplaceElements(int[] arr)
    {
        int greateNumber = arr[arr.Length -1];
        for(int i = arr.Length -1; i>=0; i--)
        {
            int currentNum = arr[i];
           
            if(i == arr.Length -1)
                arr[i] = -1;
            else
            {
                arr[i] = greateNumber;
                if(currentNum > greateNumber)
                    greateNumber = currentNum;
            }
        }
        return arr;
    }
}