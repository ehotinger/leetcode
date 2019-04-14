// https://leetcode.com/problems/subsets/
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) 
    {     
        IList<IList<int>> allSubsets = new List<IList<int>>();
        IList<int> subset = new List<int>();
        RecursiveSubsets(0, nums, subset, allSubsets);
        return allSubsets;
    }
    
    public static void RecursiveSubsets(int start, int[] nums, IList<int> subset, IList<IList<int>> allSubsets)
    {
        var temp = new List<int>(subset);

        // [[1,2,3],[1,2],[1,3],[1],[2,3],[2],[3],[]]
        for(int i = start; i < nums.Length; i++) {
            temp.Add(nums[i]);
            RecursiveSubsets(i+1, nums, temp, allSubsets);
            temp.Remove(nums[i]);
        }
        
        allSubsets.Add(temp);
    }
}