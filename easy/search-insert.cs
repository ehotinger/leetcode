// https://leetcode.com/problems/search-insert-position/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums == null || nums.Length==0) return 0;
        
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right) {
            int middle = left+(right-left)/2;
            
            if(nums[middle] < target ) {
                left = middle+1;
            } else if (nums[middle] > target ) {
                right = middle -1;
            } else{
                return middle;
            }
        }
        
        
        
        return left;
    }
}