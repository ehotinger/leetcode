/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// Start: 10:11pm
// End: 10:27pm
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        // Test case:
        // 2 -> 4 -> 3
        // 9 -> 5
        // 1 -> 0 -> 4
        
        var head = new ListNode(0);
        var temp = head;
        
        int carryOver = 0;
        while(l1 != null || l2 != null) {
            var total = 0;
            
            if(l1 != null && l2 != null) {
                total = l1.val + l2.val + carryOver;
            } else if (l1 != null) {
                total = l1.val + carryOver;
            } else if (l2 != null) {
                total = l2.val + carryOver;
            }
            
            carryOver = total / 10;
            total %= 10;
            
            temp.next = new ListNode(total);
            
            if (l1 != null) {
                l1 = l1.next;
            }
            if (l2 != null) {
                l2 = l2.next;
            }
            
            temp = temp.next;
        }
        
        if (carryOver > 0) {
            temp.next = new ListNode(1);
        }
        
        return head.next;
    }
}