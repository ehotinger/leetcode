public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>();
        var result = new int[2];
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.TryGetValue(target-nums[i], out var index))
            {
                result[0] = index;
                result[1] = i;
            }
            
            hash.TryAdd(nums[i], i);
        }
        
        return result;
    }
}