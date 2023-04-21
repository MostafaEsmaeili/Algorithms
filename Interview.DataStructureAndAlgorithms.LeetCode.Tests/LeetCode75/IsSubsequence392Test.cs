using Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.LeetCode75;

public class IsSubsequence392Test
{
    [Theory]
    [InlineData("abc","ahbgdc",true)]
    [InlineData("axc","ahbgdc",false)]
    [InlineData("aaaaaa","bbaaaa",false)]

    public void Should_Pass_Input(string s,string t, bool expected)
    {
        var algo = new IsSubsequence392();
        var actual = algo.IsSubsequence(s,t);
        Assert.Equal(expected, actual);
    }
}