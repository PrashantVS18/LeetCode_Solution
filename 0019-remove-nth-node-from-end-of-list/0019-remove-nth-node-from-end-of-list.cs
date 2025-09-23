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
        int size = 0;
        ListNode Current = head;
        while(Current!= null)
        {
            size++;
            Current = Current.next;
        }
        if(size == 1 && n == 1)
        {
            head = head.next;
            return head;
        }
        int deletingIndex = size - n;
        if(deletingIndex == 0)
        {
            return head.next;
        }
        size = 1;
        Current = head;
        while(size < deletingIndex)
        {
            size++;
            Current = Current.next;
        }
        Console.WriteLine(Current.val);
        if(Current.next.next != null)
        {
            Current.next = Current.next.next;
        }
        else {
            Current.next = null;
        }
        return head;
    }
}