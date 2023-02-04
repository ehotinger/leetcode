// https://leetcode.com/problems/find-pivot-index/description/
public class Solution {
    // High level idea is to create two different arrays, which sum up from left -> right and
    // from right -> left. Then, intersect the two different arrays where they have a matching
    // value as this is what is referred to as the "pivot index."
    public int PivotIndex(int[] nums) {
        var left = new int[nums.Length];
        var right = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            if(i == 0) {
                left[i] = nums[i];
                right[nums.Length-1] = nums[nums.Length-1];
            } else {
                left[i] = left[i-1] + nums[i];
                right[nums.Length-i-1] = right[nums.Length-i] + nums[nums.Length-i-1];
            }
        }

        for(int i = 0; i < nums.Length; i++) {
            if(left[i] == right[i]) return i;
        }

        return -1;
    }
}