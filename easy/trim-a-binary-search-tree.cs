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
    public TreeNode TrimBST(TreeNode root, int L, int R) {
        if(root == null) return null;
             
        var left = TrimBST(root.left,L,R);
        var right = TrimBST(root.right,L,R);
        
        root.left = left;
        root.right = right;
        
        if(root.val <= R && root.val >= L)
            return root;
        
        if(root.val > R) return left;
        return right;
    }
}