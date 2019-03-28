/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        
        // Simplest solution: count the entire length of the array, /= 2, double loop
        // Best solution: 2 pointers, one moving at 2x rate
        var count = 0;
        var tmp = head;
        while(tmp != null) {
            count++;
            tmp = tmp.next;
        }
                
        count /= 2;
        var tmp2 = head;
        while(count > 0 && tmp2 != null) {
            tmp2 = tmp2.next;
            count--;
        }
        
        return tmp2;
    }
}