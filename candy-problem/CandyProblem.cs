namespace candy_problem;

public class CandyProblem
{
    public static object GetMissingCandies(int[] candyAmount)
    {
        if (candyAmount.Length <= 1)
            return -1;

        if (candyAmount[0] != candyAmount[1])
            return 1;
        
        return 0;
    }
}
    