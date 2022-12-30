using Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.LeetCode75;
public class RunningSumOf1dArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
    public void Should_Pass_Input(int[] input, int[] output)
    {
        var algo = new RunningSumOf1dArray();
        var result = algo.RunningSum(input);
        Assert.Equal(output, result);
    }

}