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
    public bool IsSubtree(TreeNode s, TreeNode t) {
        if(s == null && t == null) return true;
        if(s == null || t == null) return false;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(s);
        while(q.Count > 0){
            var curr = q.Dequeue();
            
            if(curr.val == t.val && IsTreeIdentical(curr, t))
                return true;
            
            if(curr.left != null) q.Enqueue(curr.left);
            if(curr.right != null) q.Enqueue(curr.right);
        }
        return false;
    }
    
    public bool IsTreeIdentical(TreeNode s, TreeNode t){
        if(s == null && t == null) return true;
        if(s == null || t == null) return false;
        
        var left = IsTreeIdentical(s.left, t.left);
        var right = IsTreeIdentical(s.right, t.right);
        var valuesAreSame = s.val == t.val;
        
        return left && right && valuesAreSame;
    }
}