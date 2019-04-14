// https://leetcode.com/problems/maximum-size-subarray-sum-equals-k/submissions/
public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        var total = 0;
        var maxLength = 0;
        var lookup = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++) {
            total += nums[i];
            if(total == k) {
                maxLength = i + 1; // starting at 0
            }  else if (lookup.ContainsKey(total - k)) {
                maxLength = Math.Max(maxLength, i-lookup[total-k]); // Delta distance between i and the previous range
            }
            
            if(!lookup.ContainsKey(total)) {
                lookup.Add(total, i);
            }
       }
                       
       return maxLength;
    }
}