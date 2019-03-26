// https://leetcode.com/problems/longest-continuous-increasing-subsequence/submissions/
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if(nums.Length == 0 || nums == null) return 0;
        int numInc = 1;
        int max = 1;
        int prev = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > prev) {
                numInc++;
            } else {
                numInc = 1;
            }
            
            max = Math.Max(max, numInc);
            prev = nums[i];
        }
        
        return max;
    }
}