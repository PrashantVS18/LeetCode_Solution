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
    public ListNode SwapPairs(ListNode head) {
     ListNode dummy = new ListNode(-1,head);
        ListNode prev = dummy;

        while(prev.next != null && prev.next.next != null)
        {
            ListNode first = prev.next;
            ListNode second = first.next;

            //swapping
             prev.next = second;
            first.next = second.next;
            second.next = first;

            prev = first;
        }
            return dummy.next;


    }
}