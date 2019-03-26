// https://leetcode.com/problems/balanced-binary-tree/submissions/
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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        var left = GetDepth(root.left);
        var right = GetDepth(root.right);
        if(Math.Abs(left-right) > 1) {
            return false;
        }
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    public int GetDepth(TreeNode root) {
        if(root == null) return 0;
        var left = GetDepth(root.left);
        var right = GetDepth(root.right);
        return Math.Max(left, right) + 1;
    }
}