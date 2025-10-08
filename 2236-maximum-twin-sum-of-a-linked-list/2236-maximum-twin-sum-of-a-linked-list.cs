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
    public int PairSum(ListNode head) {

        int maxSum = 0;
        ListNode Current = head;
        Stack<int> stack = new Stack<int>();
        int size = 0;
        while(Current != null)
        {
            size++;
            stack.Push(Current.val);
            Current = Current.next;
        }
        Current = head;
        for(int i = 0; i<size/2;i++)
        {
            int curr = stack.Pop();
            if(Current.val + curr > maxSum)
            maxSum = Current.val + curr;
            Current = Current.next;
        }
        return maxSum;

    }
}