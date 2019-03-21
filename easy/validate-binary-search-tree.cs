using System;

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
    
//    The left subtree of a node contains only nodes with keys less than the node's key.
//    The right subtree of a node contains only nodes with keys greater than the node's key.
//    Both the left and right subtrees must also be binary search trees.
    public bool IsValidBST(TreeNode root) {
        //Console.WriteLine("Preorder:");
        //PreOrder(root);
        
        //Console.WriteLine("\nInorder:");
        //InOrder(root);
            
        //Console.WriteLine("\nPostorder:");
        //PostOrder(root);
        // return false;
        
        //
        TreeNode prev = null;
        return InOrder(root, ref prev);
    }
    
    
    
    // Sample Test case: [4,2,6,1,3,5,7]
    
    // Preorder:
    //  Root Left Right
    // 4 => 2 => 1 => 3 => 6 => 5 => 7
    
    // Inorder traversal:
    // Left Root Right
    //         4
    //      2      6
    //    1   3  5   7
    // 1 => 2 => 3 => 4 => 5 => 6 => 7
    // In the case of BST, in order traversal gives nodes in an increasing order.
    
    // Postorder:
    // Left Right Root
    // 1 => 3 => 2 => 5 => 7 => 6 => 4
    
    // Do an in-order traversal of the root with a reference to the previous node.
    // Since in-order traversal guarantees that the nodes must be in an increasing order,
    // if the previous value is ever >= the current node, then we know it's an invalid BST.
    public bool InOrder(TreeNode root, ref TreeNode prev) {
        if(root == null) return true;
        
        var l = InOrder(root.left, ref prev);
        if(!l) return false;
        
        if(prev != null && prev.val >= root.val) return false;
        prev = root;
        
        return InOrder(root.right, ref prev);
    }
    
    // These are just for debugging and examples
    public void PreOrder(TreeNode root) {
        if(root == null) return;
        Console.Write(root.val + " -> ");
        PreOrder(root.left);
        PreOrder(root.right);
    }
    
    public void InOrder(TreeNode root) {
        if(root==null) return;
        InOrder(root.left);
        Console.Write(root.val + " -> ");
        InOrder(root.right);
    }
    
    public void PostOrder(TreeNode root) {
        if(root==null) return;
        PostOrder(root.left);
        PostOrder(root.right);
        Console.Write(root.val + " -> ");
    }
    
}