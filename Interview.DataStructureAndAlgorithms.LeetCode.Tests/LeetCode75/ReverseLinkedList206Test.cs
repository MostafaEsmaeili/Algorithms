using Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

namespace Interview.DataStructureAndAlgorithms.LeetCode.Tests.LeetCode75;

public class ReverseLinkedList206Test
{
    [Theory]
    [ClassData(typeof(ValidCustomerTheory))]
    public void ReverseList(ReverseLinkedList206.ListNode node)
    {
        var algo = new ReverseLinkedList206();
        var actual = algo.ReverseList(node);
        Assert.Equal(5,actual.val );
    }
    
    

}

file class ValidCustomerTheory : TheoryData<ReverseLinkedList206.ListNode>
{
    public ValidCustomerTheory()
    {
        Add(new ReverseLinkedList206.ListNode(1,
            new ReverseLinkedList206.ListNode(2, 
                new ReverseLinkedList206.ListNode(3,
                new ReverseLinkedList206.ListNode(4, 
                    new ReverseLinkedList206.ListNode(5))))));
    }
}