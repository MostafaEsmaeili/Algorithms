namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

public class ReverseLinkedList206
{
    public ListNode ReverseList(ListNode head)
    {
        if (head is null)
        {
            return null;
        }

        if (head.next is null)
        {
            return head;
        }
        var res = ReverseList(head.next,head);
        return res;
    }

    public ListNode ReverseList(ListNode head,ListNode prev)
    {
        if (head.next is not null)
        {
           var res= ReverseList(head.next, head);
            prev.next = null;
            head.next = prev;
            return res;
        }

        prev.next = null;
        return new ListNode(head.val, prev);
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