namespace Interview.DataStructureAndAlgorithms.LeetCode.LeetCode75;

public class MergeTwoLists21
{
    /// <summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    ///  Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
    ///   Return the head of the merged linked list.
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        ListNode result;
        if (list1.val > list2.val)
        {
            result = new ListNode(list2.val);
            result.next = MergeTwoLists(list1, list2.next);
        }
        else
        {
            result = new ListNode(list1.val);
            result.next = MergeTwoLists(list1.next, list2);
        }
       
        return result;
        
    }
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