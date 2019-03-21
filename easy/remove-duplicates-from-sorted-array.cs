using System;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums?.Length == 0) return 0;
        
        // Go through the entire array, if the current element is different than the last element,
        // then increment the pointer and change the stored value.
        var ptr = 0;
        for(int i = 1; i < nums.Length; i++) {
            if(nums[i-1] != nums[i]) {
                nums[++ptr] = nums[i];
            }
        }
        
        return ptr + 1;
    }
}