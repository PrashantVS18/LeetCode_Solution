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
    public bool IsPalindrome(ListNode head) {
     Stack<int> stack = new Stack<int>();
     ListNode Current = head;
     while(Current != null)
     {
        stack.Push(Current.val);
        Current = Current.next;
     }

     Current = head;
     while(Current != null)
     {
        if(Current.val != stack.Pop())
        return false;
        Current = Current.next;
     }  
     return true;  
    }
}