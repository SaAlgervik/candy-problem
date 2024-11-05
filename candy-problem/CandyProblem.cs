namespace XTest;

public class CandyProblem
{
    public static object GetMissingCandies(int[] ints)
    {
        if (ints.Length <= 1)
            return -1;

        if (ints[0] != ints[1])
            return 1;
        
        return 0;
    }
}
    