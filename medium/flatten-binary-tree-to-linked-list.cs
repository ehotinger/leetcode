// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
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
    private TreeNode prev;
    
    public void Flatten(TreeNode root) {
        if(root == null) return;
        Flatten(root.right);
        Flatten(root.left);
        root.right = prev;
        root.left = null;
        prev = root;
    }
}