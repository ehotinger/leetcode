// https://leetcode.com/problems/wiggle-sort/
public class Solution {
    public void WiggleSort(int[] nums) {
        bool larger = true;
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if((larger && nums[i] > nums[i+1]) || (!larger && nums[i] < nums[i+1]))
            {
                Swap(nums, i, i+1);
            }
            
            larger = !larger;
        }
    }
    
    private void Swap(int[] nums, int a, int b)
    {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}