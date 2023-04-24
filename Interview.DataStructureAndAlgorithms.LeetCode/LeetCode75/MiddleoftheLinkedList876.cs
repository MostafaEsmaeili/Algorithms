namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

public class MiddleoftheLinkedList876
{
    private int count = 1;
    private int index = 1;
    private ListNode result = null;
    public ListNode MiddleNode(ListNode head) {

        if (head.next is not null)
        {
            count++;
            MiddleNode(head.next);
            if (result is not null)
            {
                return result;
            }
            if (index == (count - 1))
            {
                result = head;
                return result;
            }
            else
            {
                count--;
                return head;
            }
            
        }

        index = (int)(count / 2 + 1);
        return head;
    }
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
