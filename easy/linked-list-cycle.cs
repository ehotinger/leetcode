/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    // NB: Easiest solution is just to use a hashmap
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        var slow = head;
        var fast = head.next;
        
        while(slow != null && fast != null) {
            if(slow == fast) return true;
            if(slow.next != null) {
                slow = slow.next;
              } else {
                slow = null;
            }
            if(fast.next != null && fast.next.next != null){
                fast = fast.next.next;
            }
             else{
                 fast = null;
             }
        }
        
        return false;
    }
}