namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;
public class RunningSumOf1dArray
{
    public int[] RunningSum(int[] nums)
    {
        var result = new int[nums.Length];
        result[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] + nums[i];
        }
        return result;
    }
}