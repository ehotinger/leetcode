/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
// https://leetcode.com/problems/path-sum/submissions/
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if(root == null) return false;
        
        return HasPathSum(root, 0, sum);
    }
    
    public bool HasPathSum(TreeNode root, int currentSum, int target) {
        // Leaf node
        if(root.left == null && root.right == null) {
            return currentSum + root.val == target;
        }
        
        var left = false;
        if (root.left != null ) {
            left = HasPathSum(root.left, currentSum + root.val, target);
        }
        var right = false; 
         if (root.right != null) {
             right = HasPathSum(root.right, currentSum + root.val, target);
         }
        return left || right;
    }
}