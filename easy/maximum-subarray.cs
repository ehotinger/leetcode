public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int currMax = nums[0];
        
        for(int i = 1; i< nums.Length; i++) {
            currMax = Math.Max(0, currMax);
            currMax += nums[i];
            max = Math.Max(max, currMax);
        }
        
        return max;
    }
}