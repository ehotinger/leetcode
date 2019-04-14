public class Solution {
     public int Search(int[] nums, int target) {
        return Search(nums, 0, nums.Length-1, target);
    }
    
    public int Search(int[] nums, int first, int last, int target){
        if (first > last) return -1;
        
        int mid = (first + last) / 2;
        if (nums[mid] == target) return mid;
        
        // Left half is sorted
        if (nums[first] <= nums[mid])
            if (nums[first] <= target && target <= nums[mid]) // target is in this sorted (left) half
                return Search(nums, first, mid - 1, target);
            else // target must be in the right half
                return Search(nums, mid + 1, last, target);

        // Right half is sorted
        if (nums[mid] <= nums[last])
            if (nums[mid] <= target && target <= nums[last]) // target is in this sorted (right) half
                return Search(nums, mid + 1, last, target);
            else // target must be in left half
                return Search(nums, first, mid - 1, target);
        
        return -1;
    }
}