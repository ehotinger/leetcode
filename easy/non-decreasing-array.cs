// https://leetcode.com/problems/non-decreasing-array/solution/
public class Solution {
    public bool CheckPossibility(int[] nums) {
        if(nums == null || nums.Length <= 1) return true;
        var increasing = false;
        int? problemIndex = null;
        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] < nums[i-1]) {
                if(increasing) {
                    return false;
                }
                increasing = true;
                problemIndex = i-1;
            }
        }
        
        //Console.WriteLine("problem index: " + problemIndex.Value);
        
        return (problemIndex == null  || 
                problemIndex.Value == 0 || // The start of the array
                problemIndex.Value == nums.Length - 2 || // The end of the array
                nums[problemIndex.Value-1] <= nums[problemIndex.Value+1] || // Immediate surroundings
                nums[problemIndex.Value] <= nums[problemIndex.Value+2] // 2 in the future
               );
    }
}