// https://leetcode.com/problems/permutations/
public class Solution {
    private IList<IList<int>> lists = new List<IList<int>>();
    public IList<IList<int>> Permute(int[] nums) {
        Permute(nums, new List<int>());
        return lists;
    }
    
    public void Permute(int[] nums, List<int> built) {
        if(built.Count == nums.Length) {
            lists.Add(built);
        }
        
        for(int i = 0; i < nums.Length; i++) {
            if(built.Contains(nums[i])) continue;
            var temp = new List<int>(built);
            temp.Add(nums[i]);
            Permute(nums, temp);
        }
    }
}