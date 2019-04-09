// https://leetcode.com/problems/wiggle-sort-ii/
public class Solution {
    public void WiggleSort(int[] nums) {
        if(nums == null || nums.Length <= 1) return;
        Array.Sort(nums);
        
        int[] ret = new int[nums.Length];
        
        // Just put sorted numbers in array
        // Put largest numbers in odd indexes first
        // Then put remaining numbers in even indexes
        // So even < odd > even
        int k = nums.Length-1;
        for(int i = 1; i < nums.Length; i+=2) {
            ret[i] = nums[k--];
        }
        for(int i = 0; i < nums.Length; i+=2) {
            ret[i] = nums[k--];
        }
        
        Array.Copy(ret, nums, ret.Length);
    }
}