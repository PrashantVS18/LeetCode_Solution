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
    public ListNode ReverseBetween(ListNode head, int left, int right) {

        if (head == null || left == right)
            return head;

        // Dummy node simplifies edge cases (like left = 1)
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        // Step 1: Move `prev` to node before `left`
        ListNode prev = dummy;
        for (int i = 1; i < left; i++)
            prev = prev.next;

        // Step 2: Reverse nodes between left and right
        ListNode curr = prev.next;
        ListNode next = null;

        for (int i = 0; i < right - left; i++) {
            next = curr.next;
            curr.next = next.next;
            next.next = prev.next;
            prev.next = next;
        }

        // Step 3: Return updated list
        return dummy.next;
        
    }
}