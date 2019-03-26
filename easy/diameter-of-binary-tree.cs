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
    private int _diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        Depth(root);
        return _diameter;        
    }
    
    public int Depth(TreeNode root){
        if(root == null) return 0;
        var left = Depth(root.left);
        var right = Depth(root.right);
        _diameter = Math.Max(_diameter, left + right);
        return Math.Max(left, right) + 1;
    }
}