// https://leetcode.com/problems/minimum-size-subarray-sum/
public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        // The idea is to maintain two pointers and maintain a running sum as you go across
        // If we hit the target sum, we try to shrink the window to reduce the number of elements
        int j = 0;
        int sum = 0;
        int min = 0;
        int numConsumed = 0;
        for(int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            numConsumed++;
            
            while(sum >= s) {
                // This case could also be solved with a nullable int
                if(min == 0) {
                    min = numConsumed;
                } else {
                    min = Math.Min(numConsumed, min);
                }
                
                sum -= nums[j];
                j++;
                numConsumed--;
            }
        }
        
        return min;
    }
}