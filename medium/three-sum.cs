// https://leetcode.com/problems/3sum/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        
        var found = new HashSet<Tuple<int,int,int>>();
        IList<IList<int>> ret = new List<IList<int>>();
        
        // a + b + c = 0  => b + c = -a
        for(int i = 0; i < nums.Length; i++) {
            for(int j = i+1, k = nums.Length - 1; j < k;) {
                if(nums[j] + nums[k] > -nums[i]) {
                    k--; // Shrink window
                } else if (nums[j] + nums[k] < -nums[i]) {
                    j++; // Expand window
                } else {
                    // Target found
                    var tuple = new Tuple<int,int,int>(nums[i], nums[j], nums[k]);
                    if(!found.Contains(tuple)) {
                        var item = new List<int>() {nums[i],nums[j],nums[k]};
                        ret.Add(item);    
                    }
                    found.Add(tuple);
                    
                    j++;
                    k--;
                }
            }
        }
        
        return ret;
    }
}

// A more memory efficient solution to avoid duplicates.
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i + 1, k = nums.Length - 1; j < k; )
            {
                if(nums[j] + nums[k] > -nums[i]) k--;
                else if (nums[j] + nums[k] < -nums[i]) j++;
                else
                {
                    List<int> tmp = new List<int>(){nums[i],nums[j],nums[k]};
                    result.Add(tmp);
                    while (++j < nums.Length && nums[j] == nums[j - 1]);
                    while (--k > i && nums[k] == nums[k + 1]) ;
                }
            }
        }
        return result;
    }
}