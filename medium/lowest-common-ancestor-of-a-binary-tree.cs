// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
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
    
    // If the current subtree contains both p and q then the function result is their LCA
    // If only one is in the subtree, then the result is that one.
    // If neither are in the subtree, the result is null
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || root == p || root == q) return root;
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);
        return left == null ? right : right == null ? left : root;
    }
    
// Keeping track of the path -- uses a lot of memory
//     public List<TreeNode> pParents = null;
//     public List<TreeNode> qParents = null;
    
//     public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
//         if(root == null || p == null || q == null) return root;
        
//         // NB: O(mn) performance here, could reduce this using hashes
//         Recurse(root, p, q, new List<TreeNode>(){root});
//         for(int i = qParents.Count-1; i >= 0; i--) {
//             if(pParents.Contains(qParents[i])) {
//                 return qParents[i];
//             }
//         }
        
//         return null;
//     }
    
//     public void Recurse(TreeNode root, TreeNode p, TreeNode q, List<TreeNode> parents) {
//         if(root == null) return;
//         if(root == p) {
//             pParents = parents;
//             if(qParents != null) {
//                 return;
//             }
//         }
        
//         if(root == q) {
//             qParents = parents;
//             if(pParents != null) {
//                 return;
//             }
//         }
        
//         Recurse(root.left, p, q, new List<TreeNode>(parents){root.left});
//         Recurse(root.right, p, q, new List<TreeNode>(parents){root.right});
//     }
}