/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        
        return IsSym(root.left, root.right);
    }
    
    public bool IsSym(TreeNode a, TreeNode b) {
        if(a==null && b == null) return true;
        if(a == null || b ==null) return false;
        
        var l1 = IsSym(a.left, b.right);
        var r1 = IsSym(a.right, b.left);
        
        return l1 && r1 && a.val == b.val;
    }
}