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
    public ListNode RotateRight(ListNode head, int k) {

        if(head == null || head.next == null || k == 0)
        {
            return head;
        }
        int size = 0;
        ListNode Current = head;      
        while(Current != null)
        {
            size++;
            Current = Current.next;
        }
        int newK = k % size;

        if(newK == size || newK == 0)
        {
            return head;
        }
        int z = size - newK;
        Current = head;
        while(z != 1)
        {
            z--;
            Current = Current.next;
        }

        Console.WriteLine(Current.val);
        ListNode newHead = Current.next;
        Current.next = null;
        ListNode newCurrent = newHead;
        while(newCurrent.next != null)
        {
            newCurrent = newCurrent.next;

        }
        Console.WriteLine(newCurrent.val);
        newCurrent.next = head;
        return newHead;
    }
}