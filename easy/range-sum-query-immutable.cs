// https://leetcode.com/problems/range-sum-query-immutable/submissions/
public class NumArray {
    // 3, -5, 2, -1 => -1
    // [-2, 0, 3, -5, 2, -1]
    // [-2, -2, 1, -4, -2, -3]
    // sum(2,5) => -3 - -2
    
    private readonly int[] _cache;
    
    public NumArray(int[] nums) {
        _cache = new int[nums.Length];
        var sumSoFar = 0;
        for(int i = 0; i < nums.Length; i++ ) {
            sumSoFar += nums[i];
            _cache[i] = sumSoFar;
        }
    }
    
    public int SumRange(int i, int j) {
        if ( i == 0 ) return _cache[j];
        return _cache[j] - _cache[i-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */