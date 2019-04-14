/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// Start time: 1:59pm
// End time: 2:02pm
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || p == null || q == null) return root;
        
        var ancestor = root;
        while(ancestor != null) {  
            if(ancestor.val > p.val && ancestor.val > q.val) {
                ancestor = ancestor.left;
            } else if (ancestor.val < p.val && ancestor.val <q.val){
                ancestor = ancestor.right;
            } else {
                return ancestor;
            }
        }
        
        return ancestor;
    }
}