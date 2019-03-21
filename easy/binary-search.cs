public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, 0, nums.Length-1, target);
    }
    
    public int BinarySearch(int[] nums, int left, int right, int target) {
        while(left <= right) {
            int middle = left + (right-left)/2;
            if(nums[middle] == target) {
                return middle;
            } else if (nums[middle] > target) {
                right = middle-1;
            } else{
                left = middle + 1;
            }
        }
        
        return -1;
    }
}