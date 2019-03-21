public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        // Keep two pointers, one for the left and one for the right. If the two pointers are greater than the target,
        // move the right-most pointer to the left.
        // If it's less than the target value, move the left pointer to the right.
        int left = 0;
        int right = numbers.Length-1;
        while(left < right) {
            if(numbers[left] + numbers[right] == target) {
                return new int[2]{left+1, right+1}; // The +1 is just because the reported indices aren't 0-based.
            }
            if(numbers[left] + numbers[right] > target) {
                --right;
            } else if(numbers[left] + numbers[right] < target) {
                ++left;
            }
        }
        
        return null;
    }
}