using System.Runtime.Versioning;
using System.Linq;
namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;
public class FindPivotIndex
{
    public int PivotIndex(int[] input)
    {
        int currentLeftItemsSum = 0;
        int currentRightItemsSum = input[1..].Sum();
        if (currentLeftItemsSum == currentRightItemsSum)
        {
            return 0;
        }
        for (int i = 1; i < input.Length; i++)
        {
            currentLeftItemsSum += input[i - 1];
            currentRightItemsSum -= input[i];
            if (currentLeftItemsSum == currentRightItemsSum)
            {
                return i;
            }
        }
        return -1;
    }
}