https://leetcode.com/problems/longest-palindromic-substring/solution/
// Brute-force:
//      => for each substring in s, check if it's a palindrome. Record the max.
//      => even after optimizations, brute force approach times out.

public class Solution {

    // Expanding around the center.
    public string LongestPalindrome(string s) {
        if (s == null || s.Length <= 0) return string.Empty;
        int start = 0, end = 0;
        for(int i = 0; i < s.Length; i++ ) {
            var len1 = expand(s, i, i);
            var len2 = expand(s, i, i+1);
            var len = Math.Max(len1, len2);
            if (len > end - start) {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        
        return s.Substring(start, end+1-start);
    }
    
    private int expand(string s, int left, int right) {
        int L = left, R = right;
        while (L >= 0 && R < s.Length && s[L] == s[R]) {
            L--;
            R++;
        }
        return R - L - 1;
    }

    // Brute force with some caching optimizations.
    // public string LongestPalindrome(string s) {
    //     var longestPalindrome = string.Empty;
    //     var cache = new Dictionary<string, bool>();
    //     for(int i = 0; i < s.Length; i++) {
    //         for(int j = 1; j <= s.Length - i; j++) {
    //             var substr = s.Substring(i, j);
                
    //             // Some crude optimizations
    //             if(substr.Length < longestPalindrome.Length) continue;
    //             if(!cache.ContainsKey(substr)) {
    //                 cache[substr] = IsPalindrome(substr);
    //             }
                
    //             if(cache[substr] && substr.Length > longestPalindrome.Length) {
    //                 longestPalindrome = substr;
    //             }
    //         }
    //     }
        
    //     return longestPalindrome;
    // }
    
    // public bool IsPalindrome(string s) {
    //     for(int i = 0; i < s.Length/2; i++) {
    //         if(s[i] != s[s.Length-i-1]) {
    //             return false;
    //         }
    //     }
        
    //     return true;
    // }
}