public class Solution {
    public void Rotate(int[] nums, int k) {
        if(k==0) return;
        
        k %= nums.Length;
        // 1,2,3,4,5,6,7
        // [4,3,2,1,7,6,5] => [5,6,7,1,2,3,4]
        Reverse(nums, 0, nums.Length-k-1);
        Reverse(nums, nums.Length-k, nums.Length-1);
        Reverse(nums, 0, nums.Length-1);
    }
    
    public void Reverse(int[] nums, int start, int end) {
        for(int i = 0; i <= (end-start)/2; i++) {
            if(start+i >= nums.Length || end-i < 0 || end-i >= nums.Length || start+i < 0) return;
            var temp = nums[start+i];
            nums[start+i] = nums[end-i];
            nums[end-i] = temp;
        }
    }
}