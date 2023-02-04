/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// Idea is simple: just traverse the entire tree and sum up all the nodes in a global variable
// when a particular node is in the range [x,y] inclusive.
public class Solution {
    private int _sum;
    public int RangeSumBST(TreeNode root, int low, int high) {
        RangeSumBSTHelper(root,low,high);
        return _sum;
    }

    public void RangeSumBSTHelper(TreeNode root, int low, int high) {
        if(root==null) return;
        if(root.val >= low && root.val <= high) _sum+=root.val;
        RangeSumBST(root.left,low,high);
        RangeSumBST(root.right,low,high);
    }
}