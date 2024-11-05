using System;
using System.Linq;

namespace candy_problem;

public abstract class CandyProblem
{
    public static object GetMissingCandies(int[] candyAmounts)
    {
        if (candyAmounts.Length <= 1)
            return -1;

        var mostCandies = candyAmounts.Max();

        return candyAmounts.Sum(AmountDifference(mostCandies));
    }

    private static Func<int, int> AmountDifference(int hadMostAmount)
    {
        return amount => hadMostAmount - amount;
    }
}
    