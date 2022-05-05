namespace StrictlyIncreasingProject;

public class Program
{
    public static void Main()
    {
        
    }

    public bool IsStrictlyIncreasing(int[] testArray)
    {
        int badCount = 0;
        
        for (var i = 0; i < testArray.Length - 1; i++)
        {
            // check if next element in array is smaller than previous
            if (!IsNextElementStrictlyIncreasing(testArray, i))
            {
                badCount++;
                if (!CheckElementAfterNext(testArray, i))
                {
                    badCount++;
                }
            }
            
        }
        if (badCount > 1) return false;

        return true;
    }

    private bool CheckElementAfterNext(int[] testArray, int i)
    {
        if (i + 2 <= testArray.Length - 1)
        {
            if (testArray[i] < testArray[i + 2])
            {
                return true;
            }
        }
        return false;
    }

    private static bool IsNextElementStrictlyIncreasing(int[] testArray, int i)
    {
        if (testArray[i] < testArray[i + 1])
        {
            return true;
        }

        return false;
    }
}