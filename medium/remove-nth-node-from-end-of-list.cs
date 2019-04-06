/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null) return null;
        
        int total = 0;
        var temp = head;
        while(temp != null) {
            total++;
            temp = temp.next;
        }
                
        int target = total - n;
        int start = 1;
        
        if(target == 0) return head.next;
        
        var curr = head;
        for(int i = start; i <= target; i++) {
            if (i == target) {
                curr.next = curr.next.next;
                break;
            }
            curr = curr.next;
        }
        
        return head;
    }
}