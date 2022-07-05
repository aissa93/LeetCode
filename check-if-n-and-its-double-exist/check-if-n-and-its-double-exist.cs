public class Solution 
{
    public bool CheckIfExist(int[] arr)
    {
        HashSet<int> addedNumers = new HashSet<int>();
        foreach( int e in arr)
        {
            if(addedNumers.Contains(e*2) || (addedNumers.Contains(e/2) && e%2 == 0))
                return true;
            addedNumers.Add(e);
        }

        return false;
    }

}