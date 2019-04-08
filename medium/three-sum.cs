// https://leetcode.com/problems/3sum/
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
                List<int> tmp = new List<int>();
                tmp.Add(nums[i]);
                tmp.Add(nums[j]);
                tmp.Add(nums[k]);
                result.Add(tmp);
                while (++j < nums.Length && nums[j] == nums[j - 1]);
                while (--k > i && nums[k] == nums[k + 1]) ;
            }
        }
    }
    return result;
}