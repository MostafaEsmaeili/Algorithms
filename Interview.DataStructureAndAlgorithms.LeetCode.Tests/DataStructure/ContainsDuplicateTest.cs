using Interview.DataStructureAndAlgorithms.LeetCode.DataStructure;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.DataStructure;

public class ContainsDuplicateTest
{
    [Theory]
    [InlineData(new int[] {1,2,3,1},true)]
    [InlineData(new int[] {1,2,3,4},false)]
    [InlineData(new int[] {1,1,1,3,3,4,3,2,4,2},true)]

    public void Should_Pass_All_Test_Cast_(int[] input, bool output)
    {
        var algo = new CheckContainsDuplicate();
        var result = algo.ContainsDuplicate(input);
        Assert.Equal(output, result);
    }
}