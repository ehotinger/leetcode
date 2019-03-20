using System;

// Given something like: "hello", "hell", "he", "foo" it will find the LongestCommonPrefix of the first two words and then reuse that
// longest common prefix to compare it to all other words, i.e.
// hello + hell => hell
// hell + he => he
// he + foo => ""
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) {
            return "";
        } else if(strs.Length == 1) {
            return strs[0];
        }
        
        var lcp = LCP(strs[0], strs[1]);
        for(int i = 2; i < strs.Length; i++) {
            lcp = LCP(lcp, strs[i]);
        }
        
        return lcp;
    }
    
    private static string LCP(string a, string b) {
        for(int i = 0; i < a.Length && i < b.Length; i++) {
            if(a[i] != b[i]) {
                if (i == 0) return "";
                return a.Substring(0, i);
            }
        }
        return a.Length > b.Length ? b : a;
    }
}