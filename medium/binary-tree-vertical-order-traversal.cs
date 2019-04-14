// https://leetcode.com/problems/binary-tree-vertical-order-traversal/
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

    // Have to use BFS to get the "top-down" vertical order correct, otherwise you could just recursively
    // go through the entire tree.
    // Use a dictionary to maintain the "vertical order" associated to the list of elements

    Dictionary<int, List<int>> verticalMapping = new Dictionary<int,List<int>>();
    private int maxLeft = 0;
    private int maxRight = 0;
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        Traverse(root, 0);
        IList<IList<int>> ret = new List<IList<int>>();
        while(maxLeft <= maxRight) {
            if(verticalMapping.ContainsKey(maxLeft)) {
                ret.Add(verticalMapping[maxLeft]);
            }
            maxLeft++;
        }
        
        return ret;
    }
    
    public void Traverse(TreeNode root, int vertical) {
        if(root == null) return;
        var q = new Queue<KeyValuePair<TreeNode, int>>();
        q.Enqueue(new KeyValuePair<TreeNode,int>(root, 0));
        while(q.Count > 0) {
            var item = q.Dequeue();
            DoMapping(item.Key, item.Value);
            if(item.Key.left != null) {
                q.Enqueue(new KeyValuePair<TreeNode, int>(item.Key.left, item.Value - 1));
            }
            if(item.Key.right != null) {
                q.Enqueue(new KeyValuePair<TreeNode, int>(item.Key.right, item.Value + 1));
            }
        }
    }
    
    public void DoMapping(TreeNode root, int vertical) {
        maxLeft = Math.Min(maxLeft, vertical);
        maxRight = Math.Max(maxRight, vertical);
        if(root == null) return;
        if(verticalMapping.ContainsKey(vertical)) {
            verticalMapping[vertical].Add(root.val);
        } else {
            verticalMapping.Add(vertical, new List<int>(){root.val});
        }
    }
}