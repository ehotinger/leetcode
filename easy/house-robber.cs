using System;

// start: 1:35pm
// finish: 1:41pm

// https://leetcode.com/problems/house-robber/submissions/
// Dynamic programming question
public class Solution {
    // [2,7,9]
    // => 2
    // => 2 || 7
    // => 2 + 9 || 7
    
    // [2,7,9,3,1]
    // => 2
    // => 2 || 7
    // => 2 + 9 || 7
    // => 2 + 9 || 7 + 3
    // => 2 + 9 + 1 || 7 + 3
    public int Rob(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        if(nums.Length == 1) return nums[0];
        
        var cache = new int[nums.Length];
        cache[0] = nums[0];
        cache[1] = Math.Max(nums[0], nums[1]);
        
        
        for(int i = 2; i < nums.Length; i++) {
            cache[i] = Math.Max(nums[i] + cache[i-2], cache[i-1]);
            //Console.WriteLine(cache[i] + " -- " + nums[i]);
        }
        
        return cache[nums.Length-1];
    }
}