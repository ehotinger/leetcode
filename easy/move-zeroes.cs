public class Solution {
    public void MoveZeroes(int[] nums) {
        int currPtr = 0;
        int numZeroes = 0;
        for(int i=0; i < nums.Length; i++) {
            if(nums[i] == 0) {
                numZeroes++;
            } else {
                nums[currPtr] = nums[i];
                currPtr++;
            }
        }
        for(int i=0; i < numZeroes; i++) {
            nums[nums.Length - i-1] = 0;
        }
    }
}