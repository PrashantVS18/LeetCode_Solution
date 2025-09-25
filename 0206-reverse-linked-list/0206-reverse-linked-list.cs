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
    public ListNode ReverseList(ListNode head) {
        ListNode Prev = null;
        ListNode Curr = head;

        while(Curr != null)
        {
            ListNode next = Curr.next;
            Curr.next = Prev;
            Prev = Curr;
            Curr = next;
        }
        return Prev;
    }
}