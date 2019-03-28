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
    // 8:45 start
    // 8:53 finish
    
    // NB: could be better optimized using a StringBuilder instead. Less allocations.
    private List<string> _treePaths = new List<string>();
    
    public IList<string> BinaryTreePaths(TreeNode root) {
        string s = string.Empty;
        MakePaths(root, s);
        return _treePaths;
    }
       
    public void MakePaths(TreeNode root, string s) {
        if(root == null) return;
        s += root.val;
        if(root.left == null && root.right == null) {
            _treePaths.Add(s);
        }
        s+= "->";
        if(root.left != null) {
            MakePaths(root.left, s);
        }
        if (root.right != null) {
            MakePaths(root.right, s);
        }
        
    }
}