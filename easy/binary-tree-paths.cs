// https://leetcode.com/problems/binary-tree-paths/
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
    private IList<string> ret = new List<string>();
    
    public IList<string> BinaryTreePaths(TreeNode root) {
        if(root == null) {
            return ret;
        }
        Recurse(root, "");
        return ret;
    }
    
    public void Recurse(TreeNode root, string path) {
        if(root.left == null && root.right == null) {
            path += root.val;
            ret.Add(path);
            return;
        }
        
        if(root.left != null) {
            Recurse(root.left, path + root.val + "->");
        }
        if(root.right != null) {
            Recurse(root.right, path + root.val + "->");
        }
    }
}