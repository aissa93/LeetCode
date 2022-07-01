public class Solution {
public bool CheckIfExist(int[] arr) {
        for(int i =0; i< arr.Length; i++)
        {
            if(this.DoubleExist(arr, arr[i], i))
                return true;
        }

        return false;
    }
    public bool DoubleExist(int[]arr, int num, int index)
    {
        bool result = false;
        double halfNum = num / 2.0;
        int doubleNum = num *2;
        for(int i =0; i< arr.Length; i++)
        {
            if(i == index)
                continue;
            if(arr[i] == halfNum || arr[i] == doubleNum)
                result = true;
        }
        return result;
    }

}