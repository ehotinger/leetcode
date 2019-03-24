// Start: 1:29pm
// End: 1:32pm
// This is essentially the fibonnaci numbers problem. Use a local cache to act like dynamic programming.
// https://leetcode.com/problems/climbing-stairs/submissions/
public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2) return n;
        var cache = new int[n];
        cache[0] = 0;
        cache[1] = 1;
        cache[2] = 2;
        
        for(int i = 3; i < n; i++) {
            cache[i] = cache[i-1] + cache[i-2];
        }
        return cache[n-1] + cache[n-2];
    }
}