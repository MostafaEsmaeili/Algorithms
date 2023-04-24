using Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.LeetCode75;

public class MiddleoftheLinkedList876Test
{
    [Theory]
    [ClassData(typeof(ValidCustomerTheory))]

    public void MiddleNode(MiddleoftheLinkedList876.ListNode head) {
        var algo = new MiddleoftheLinkedList876();
        var actual = algo.MiddleNode(head);
        Assert.True(true);
    }
}
file class ValidCustomerTheory : TheoryData<MiddleoftheLinkedList876.ListNode>
{
    public ValidCustomerTheory()
    {
        Add(new MiddleoftheLinkedList876.ListNode(1,
            new MiddleoftheLinkedList876.ListNode(2)));
    }
}