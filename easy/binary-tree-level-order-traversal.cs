using System;
using System.Collections;
using System.Collections.Generic;

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var ret = new List<IList<int>>();
        
        if(root==null) return ret;
        
        while(q.Count > 0) {
            var currLevel = new List<int>(q.Count);
            var temp = q.Count;
            while(temp > 0) {
                var item = q.Dequeue();
                currLevel.Add(item.val);
                if(item.left != null) {
                    q.Enqueue(item.left);
                }
                if(item.right != null) {
                    q.Enqueue(item.right);
                }
                temp--;
            }
            
            ret.Add(currLevel);
        }
        
        return ret;
    }
}