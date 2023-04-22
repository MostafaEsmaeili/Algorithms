using Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.LeetCode75;

public class IsomorphicStrings205Test
{
    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    [InlineData("badc", "baba", false)]
    [InlineData("bbbaaaba","aaabbbba", false)]
    public void Should_Pass_Input(string s, string t, bool expected)
    {
        var algo = new IsomorphicStrings205();
        var actual = algo.IsIsomorphic(s, t);
        Assert.Equal(expected, actual);
    }
}