using Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.LeetCode75;
public class FindPivotIndexTest
{
    [Theory]
    [InlineData(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [InlineData(new int[] { 1, 2, 3 }, -1)]
    [InlineData(new int[] { 2, 1, -1 }, 0)]
    public void Should_Pass_Input(int[] input, int output)
    {
        var algo = new FindPivotIndex();
        var result = algo.PivotIndex(input);
        Assert.Equal(output, result);
    }
}