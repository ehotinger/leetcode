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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums == null || nums.Length == 0) return null;
        return BinarySearch(nums, 0, nums.Length-1);
    }
    
    public TreeNode BinarySearch(int[] nums, int left, int right) {
        if(left <= right) {
            var middle = (left+right)/2;
            var root = new TreeNode(nums[middle]);
            root.left = BinarySearch(nums, left, middle-1);
            root.right = BinarySearch(nums, middle+1, right);
            return root;
        }
        
        return null;
    }
}