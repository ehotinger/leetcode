// start: 1:44pm
// end: 1:57pm
// https://leetcode.com/problems/isomorphic-strings/submissions/
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s.Length ==0 && t.Length==0) return true;
        
        // We have to make sure that we don't map multiple characters to a single character.
        // I.e., for a case like abc, aaa
        // In this approach we use a "used" hash set to make sure that we don't map the same character twice.
        var used = new HashSet<char>();
        var lookup = new Dictionary<char, char>();
        for(int i = 0; i < s.Length; i++) {
            if(lookup.ContainsKey(s[i])) {
                var expected = lookup[s[i]];
                if(t[i] != expected) {
                    return false;
                }
            } else if (used.Contains(t[i])) {
                return false;
            } else {
                lookup.Add(s[i], t[i]);
                used.Add(t[i]);
            }
        }
                
        return true;
    }
}