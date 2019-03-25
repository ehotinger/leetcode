// https://leetcode.com/problems/word-pattern/submissions/
public class Solution {
    public bool WordPattern(string pattern, string str) {
        var lookup = new Dictionary<char, string>();
        
        var words = str.Split(' ');
        if(words.Length != pattern.Length) {
            return false;
        }
        
        var used = new HashSet<string>();
        
        for(int i = 0; i < pattern.Length; i++) {
            var c = pattern[i];
            if(lookup.ContainsKey(c)) {
                if(lookup[c] != words[i]) {
                    return false;
                }
            } else if (used.Contains(words[i])) {
                return false;
            } else {
                lookup[c] = words[i];
                used.Add(words[i]);
            }
        }
        
        return true;
    }
}