/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null)
            return head;

        int length = 0;
        ListNode node = head;
        while (node != null) { // count total nodes
            length++;
            node = node.next;
        }

        ListNode dummy = new ListNode(0, head);
        for (int step = 1; step < length; step <<= 1) // merge sublists of size 1,2,4,8...
        {
            ListNode prev = dummy;
            ListNode curr = dummy.next;

            while (curr != null)
            {
                // Split left sublist
                ListNode left = curr;
                ListNode right = Split(left, step);
                curr = Split(right, step);

                // Merge two sorted halves
                prev = Merge(left, right, prev);
            }
        }

        return dummy.next;
    }

    // Split list into two parts: first 'size' nodes, return head of next part
    private ListNode Split(ListNode head, int size) {
        for (int i = 1; head != null && i < size; i++)
            head = head.next;

        if (head == null) return null;

        ListNode second = head.next;
        head.next = null; // break link
        return second;
    }

    // Merge two sorted lists and attach after 'head'
    private ListNode Merge(ListNode l1, ListNode l2, ListNode head) {
        ListNode current = head;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        current.next = (l1 != null) ? l1 : l2;

        // Move to end of merged part
        while (current.next != null)
            current = current.next;

        return current;
    }
}