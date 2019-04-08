// https://leetcode.com/problems/merge-two-sorted-lists/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode prev = null;
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        if(l1 == null && l2 == null) return null;
        
        if(l1.val > l2.val) {
            prev = l2;
            l2 = l2.next;
        } else {
            prev = l1;
            l1 = l1.next;
        }
        
        ListNode ret = new ListNode(-1);
        ret.next = prev;
        
        while(l1 != null || l2 != null) {
            if(l1 != null && l2 != null) {
                if(l1.val > l2.val) {
                    prev.next = l2;
                    l2 = l2.next;
                } else {
                    prev.next = l1;
                    l1 = l1.next;
                }
            } else if (l1 != null) {
                prev.next = l1;
                l1 = l1.next;
            } else if (l2 != null) {
                prev.next = l2;
                l2 = l2.next;
            }
            
            prev = prev.next;
        }
        
        return ret.next;
    }
}