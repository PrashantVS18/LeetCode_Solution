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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
         // Step 1: Count the total nodes
        int size = 0;
        ListNode current = head;
        while (current != null) {
            size++;
            current = current.next;
        }

        // Step 2: If we need to remove the head
        int deletingIndex = size - n;
        if (deletingIndex == 0) return head.next;

        // Step 3: Traverse to the node just before the one to delete
        current = head;
        for (int i = 1; i < deletingIndex; i++) {
            current = current.next;
        }

        // Step 4: Remove the nth node
        current.next = current.next.next;

        return head;

    }
}