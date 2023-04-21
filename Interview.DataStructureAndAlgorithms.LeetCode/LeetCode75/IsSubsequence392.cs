namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

public class IsSubsequence392
{
    /// <summary>
    /// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

    /// A subsequence of a string is a new string that is formed
    /// from the original string by deleting some (can be none) of the characters without disturbing
    /// the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public bool IsSubsequence(string s, string t)
    {
        int lastIndex = -1;
        if (s.Length > t.Length)
            return false;
        if (s.Length == t.Length)
            return s == t;
        foreach (var chr in s)
        {
            if (t.IndexOf(chr,lastIndex+1) is var a && a < 0)
                return false;
            else
            {
                if (lastIndex > a)
                    return false;
                else
                {
                    lastIndex = a;
                }
            }
        }

        return true;
    }
}