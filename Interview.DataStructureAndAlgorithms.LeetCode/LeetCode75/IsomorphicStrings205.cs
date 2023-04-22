using System.ComponentModel;

namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;
public class IsomorphicStrings205
{
    /// <summary>
    /// Given two strings s and t, determine if they are isomorphic.
    ///Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    ///All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>

    public bool IsIsomorphic(string s, string t)
    {
        var result = new char?[s.Length];
        if (s.Length == 1)
        {
            return true;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (result[i] is not null)
                continue;
            if(Array.IndexOf(result,t[i]) >-1)
                continue;
            result[i] = t[i];
  
            if(i == s.Length)
                break;
            int sIndex = i + 1;
            while (sIndex<s.Length &&  s.IndexOf(s[i], sIndex) is var a && a > -1)
            {
                result[a] = t[i];
                sIndex = a +1;
            }
        }
        return string.Join("", result) == t;
    }
}