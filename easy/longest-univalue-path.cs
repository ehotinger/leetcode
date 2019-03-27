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
    // 5 => 0   
    private int _longestPath = int.MinValue;
    
    public int LongestUnivaluePath(TreeNode root) {
        if(root == null) return 0;
        CountLongestPath(root, root.val);
        return _longestPath;
    }
    
    public int CountLongestPath(TreeNode root, int prevValue) {
        if(root == null) return 0;
                
        var numLeft = CountLongestPath(root.left, root.val);
        var numRight = CountLongestPath(root.right, root.val);
        _longestPath = Math.Max(numLeft + numRight, _longestPath);
        
        if(root.val == prevValue) return Math.Max(numLeft, numRight) + 1;
        return 0;
    }
    

}