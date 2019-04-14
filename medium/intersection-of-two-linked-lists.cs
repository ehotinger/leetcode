/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        // Trivial approach: use a HashMap and check if we hit a duplicate node.
        if(headA == null || headB == null) return null;
        var ptr1 = headA;
        var ptr2 = headB;
        
        // Use two pointers -- when either pointer hits the end of the list, wrap it back to the other list's head
        // If there's an intersection we'll hit it in O(mn) time.
        // If there's no intersection we'll wrap twice and then hit null at the end of both lists.
        while(ptr1 != null || ptr2 != null) {
            if(ptr1 == ptr2) {
                return ptr1;
            }
            
            ptr1 = ptr1 == null ? headB : ptr1.next;
            ptr2 = ptr2 == null ? headA : ptr2.next;
        }
        
        return null;
    }
}