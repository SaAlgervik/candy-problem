namespace XTest;

public class UnitTest1
{
    [Fact]
    public void CandyProblem_OneChild_ReturnMinusOne()
    {
        var result = CandyProblem.GetMissingCandies([6]);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void CandyProblem_TwoChildrenWithSameAmount_ReturnZero()
    {
        var result = CandyProblem.GetMissingCandies([6, 6]);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CandyProblem_NoChildren_ReturnMinusOne()
    {
        var result = CandyProblem.GetMissingCandies([]);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void CandyProblem_TwoChildren_ReturnsDifference()
    {
        var result = CandyProblem.GetMissingCandies([1, 2]);

        Assert.Equal(1, result);
    }
}
