// NB: uses a local cache to speed up subsequent re-access, on Leetcode this degrades performance.
public class Solution {
    public int Fib(int N) {
        if (N==0) return 0;
        if (N==1) return 1;
        
        var cache = new int[N];
        cache[0] = 0;
        cache[1] = 1;
        
        
        for(int i=2; i < N; i++) {
            cache[i] = cache[i-1] + cache[i-2];
        }
        
        return cache[N-1] + cache[N-2];
    }
}