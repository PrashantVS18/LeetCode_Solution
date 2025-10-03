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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null)
        {
            return head;
        }

        ListNode dummy = new ListNode(-1,head);
        ListNode prev = dummy;
        ListNode Current = dummy.next;

        while(Current != null)
        {
            if(Current.next != null && Current.val == Current.next.val)
            {
                while(Current.next != null && Current.val == Current.next.val)
                {
                    Current = Current.next;
                }
                prev.next = Current.next;
                
            }
            else {
                prev = prev.next;
            }

            Current = Current.next;
        }

        return dummy.next;
        
    }
}