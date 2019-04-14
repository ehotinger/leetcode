// https://leetcode.com/problems/count-univalue-subtrees/
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
    private int count = 0;
    public int CountUnivalSubtrees(TreeNode root) {
        Count(root);
        return count;
    }
    
    public bool Count(TreeNode root) {
        if(root == null) return true;
        
        var left = Count(root.left);
        var right = Count(root.right);
        
        if (!left || !right) return false;
        
        if(root.left != null && root.val != root.left.val) return false;
        if(root.right != null && root.val != root.right.val) return false;
        
        count++;
        return true;
    }
}