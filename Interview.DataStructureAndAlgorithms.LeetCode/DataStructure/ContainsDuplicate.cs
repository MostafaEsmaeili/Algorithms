namespace Interview.DataStructureAndAlgorithms.LeetCode.DataStructure;

public class CheckContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length==1)
        {
            return false;
        }

        var dic = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.TryAdd(nums[i],1))
            {
                return true;
            }
        }
        return false;
    }
}