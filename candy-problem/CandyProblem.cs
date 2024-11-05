namespace candy_problem;

public class CandyProblem
{
    public static object GetMissingCandies(int[] candyAmount)
    {
        if (candyAmount.Length <= 1)
            return -1;
        
        var difference = 0;

        var hadMostAmount = candyAmount.Max();

        foreach (var amount in candyAmount)
        {
            difference += hadMostAmount - amount;
        }
        
        return difference;
    }
}
    