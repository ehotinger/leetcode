// https://leetcode.com/problems/monotonic-array/submissions/
public class Solution {
    public bool IsMonotonic(int[] A) {
        var allDecreasing = true;
        var allIncreasing = true;
        
        if(A == null || A.Length <= 1) return true;
        
        for(int i = 1; i < A.Length; i++ ){
            allIncreasing &= A[i] >= A[i-1];
            allDecreasing &= A[i] <= A[i-1];
        }
        
        return allDecreasing || allIncreasing;
    }
}