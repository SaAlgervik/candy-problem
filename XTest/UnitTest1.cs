namespace XTest;

public class UnitTest1
{
    [Fact]
    public void CandyProblem_OneChild_ReturnMinusOne()
    {
        
        var result = CandyProblem.GetMissingCandies([6]);
        
        Assert.Equal(-1, result);

    }

}
